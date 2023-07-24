using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Commands.Models.EmployeeModel.Response
{
    public class DeleteEmployeeResponse
    {
        public int Result { get; set; }

        public DeleteEmployeeResponse(int result)
        {
            Result = result;
        }
    }
}
