using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Models.EmployeeModel.Response;

namespace TCCS.Commands.Queries.Employee
{
    public class GetEmployeeByIdQuery : IQuery<GetEmployeeByIdReponse>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery(int id) {
            Id = id;
        }
    }
}
