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
    public class GetEmployeeByIdQueryHandler : IQueryHandler<GetEmployeeByIdQuery, GetEmployeeByIdReponse>
    {
        private readonly IEmployeeRepository _empRepo;
        private readonly IMapper _mapper;

        public GetEmployeeByIdQueryHandler(IEmployeeRepository empRepo,
            IMapper mapper)
        {
            _empRepo = empRepo;
            _mapper = mapper;
        }

        public async Task<GetEmployeeByIdReponse> ExecuteQuery(GetEmployeeByIdQuery query)
        {
            var data = await _empRepo.GetById<GetEmployeeById>(query.Id);

            var res = _mapper.Map<EmployeeModel>(data);

            return new GetEmployeeByIdReponse(res);
        }
    }
}
