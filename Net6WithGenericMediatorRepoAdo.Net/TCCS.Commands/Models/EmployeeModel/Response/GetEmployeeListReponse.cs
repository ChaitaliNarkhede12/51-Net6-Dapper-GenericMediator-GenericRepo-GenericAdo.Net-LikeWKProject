using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands.Models.EmployeeModel.Response
{
    public class GetEmployeeListReponse
    {
        public IEnumerable<EmployeeModel> Employees { get; set; }

        public GetEmployeeListReponse(IEnumerable<EmployeeModel> employees) {
            Employees = employees;
        }
    }
}
