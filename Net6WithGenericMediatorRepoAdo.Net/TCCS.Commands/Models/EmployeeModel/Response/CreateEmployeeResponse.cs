using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands.Models.EmployeeModel.Response
{
    public class CreateEmployeeResponse
    {
        public int Result { get; set; }

        public CreateEmployeeResponse(int result)
        {
            Result = result;
        }
    }
}
