using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Models.EmployeeModel.Response;
using TCCS.Commands.Models.EmployeeModel;
using TCCS.Commands.Queries.Employee;
using TCCS.Domain.Interfaces;
using TCCS.Domain.Models.Employees;

namespace TCCS.Commands.Handlers.EmployeeHandlers
{
    public class GetEmployeeListQueryHandler : IQueryHandler<GetEmployeeListQuery, GetEmployeeListReponse>
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;

        public GetEmployeeListQueryHandler(IEmployeeRepository empRepo,
            IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        public async Task<GetEmployeeListReponse> ExecuteQuery(GetEmployeeListQuery query)
        {
            var data = await _empRepo.GetList<GetEmployeeList>();

            var res = _mapper.Map<IEnumerable<EmployeeModel>>(data);

            return new GetEmployeeListReponse(res);
        }
    }
}
