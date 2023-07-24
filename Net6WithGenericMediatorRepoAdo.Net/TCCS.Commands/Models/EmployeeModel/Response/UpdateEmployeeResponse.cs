using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands.Models.EmployeeModel.Response
{
    public class UpdateEmployeeResponse
    {
        public int Result { get; set; }

        public UpdateEmployeeResponse(int result)
        {
            Result = result;
        }
    }
}
