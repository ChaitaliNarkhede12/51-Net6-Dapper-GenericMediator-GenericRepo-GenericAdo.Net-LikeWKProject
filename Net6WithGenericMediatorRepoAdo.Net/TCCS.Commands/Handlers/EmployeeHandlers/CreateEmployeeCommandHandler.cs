using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Command.Employee;
using TCCS.Commands.Models.EmployeeModel.Response;
using TCCS.Commands.Models.EmployeeModel;
using TCCS.Domain.Interfaces;
using TCCS.Domain.Models.Employees;

namespace TCCS.Commands.Handlers.EmployeeHandlers
{
    public class CreateEmployeeCommandHandler : IQueryHandler<CreateEmployeeCommand, CreateEmployeeResponse>
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;

        public CreateEmployeeCommandHandler(IEmployeeRepository empRepo,
            IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        public async Task<CreateEmployeeResponse> ExecuteQuery(CreateEmployeeCommand query)
        {
            var employee = _mapper.Map<Employee>(query);

            var data = await _empRepo.Addsync<AddEmployee>(employee);

            return new CreateEmployeeResponse(data);
        }
    }
}
