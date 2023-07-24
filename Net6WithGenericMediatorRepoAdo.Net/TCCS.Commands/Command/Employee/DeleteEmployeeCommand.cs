using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Models.EmployeeModel.Response;

namespace TCCS.Commands.Command.Employee
{
    public class DeleteEmployeeCommand : IQuery<DeleteEmployeeResponse>
    {
        public int Id { get; set; }

        public DeleteEmployeeCommand(int id)
        {
            Id = id;
        }
    }
}
