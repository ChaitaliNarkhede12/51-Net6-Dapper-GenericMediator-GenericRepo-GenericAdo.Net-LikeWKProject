using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCCS.Commands;
using TCCS.Commands.Command.Employee;
using TCCS.Commands.Models.EmployeeModel;
using TCCS.Commands.Queries.Employee;

namespace TCCS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var getEmployeeListQuery = new GetEmployeeListQuery(); 

            var res = await _mediator.ExecuteQuery(getEmployeeListQuery).ConfigureAwait(false);

            return Ok(res);
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            var getEmployeeByIdQuery = new GetEmployeeByIdQuery(id);

            var res = await _mediator.ExecuteQuery(getEmployeeByIdQuery).ConfigureAwait(false);

            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeModel model)
        {
            var addEmployeeCommand = new CreateEmployeeCommand(model.Id, model.Name, model.City);

            var res = await _mediator.ExecuteQuery(addEmployeeCommand).ConfigureAwait(false);

            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeModel model)
        {
            var updateEmployeeCommand = new UpdateEmployeeCommand(model.Id, model.Name, model.City);

            var res = await _mediator.ExecuteQuery(updateEmployeeCommand).ConfigureAwait(false);

            return Ok(res);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var updateEmployeeCommand = new DeleteEmployeeCommand(id);

            var res = await _mediator.ExecuteQuery(updateEmployeeCommand).ConfigureAwait(false);

            return Ok(res);
        }
    }
}
