using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands.Models.EmployeeModel.Response
{
    public  class GetEmployeeByIdReponse
    {
        public EmployeeModel Employee { get; set; }

        public GetEmployeeByIdReponse(EmployeeModel employee)
        {
            Employee = employee;
        }
    }
}
