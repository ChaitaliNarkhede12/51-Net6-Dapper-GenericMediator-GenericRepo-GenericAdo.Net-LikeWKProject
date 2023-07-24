using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Command.Employee;
using TCCS.Commands.Models.EmployeeModel.Response;
using TCCS.Domain.Interfaces;
using TCCS.Domain.Models.Employees;

namespace TCCS.Commands.Handlers.EmployeeHandlers
{
    public class DeleteEmployeeCommandHandler : IQueryHandler<DeleteEmployeeCommand, DeleteEmployeeResponse>
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;

        public DeleteEmployeeCommandHandler(IEmployeeRepository empRepo,
            IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        public async Task<DeleteEmployeeResponse> ExecuteQuery(DeleteEmployeeCommand query)
        {
            var data = await _empRepo.RemoveAsync<RemoveEmployee>(query.Id);

            return new DeleteEmployeeResponse(data);
        }
    }
}
