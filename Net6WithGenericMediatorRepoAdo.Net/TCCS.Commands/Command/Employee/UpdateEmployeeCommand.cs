using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Models.EmployeeModel.Response;

namespace TCCS.Commands.Command.Employee
{
    public class UpdateEmployeeCommand : IQuery<UpdateEmployeeResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public UpdateEmployeeCommand(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }
    }
}
