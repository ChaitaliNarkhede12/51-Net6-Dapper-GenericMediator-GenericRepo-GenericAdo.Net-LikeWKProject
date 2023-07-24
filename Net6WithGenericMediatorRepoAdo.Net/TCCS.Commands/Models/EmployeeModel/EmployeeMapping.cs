using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Commands.Command.Employee;
using TCCS.Domain.Models.Employees;

namespace TCCS.Commands.Models.EmployeeModel
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping() {
            CreateMap<EmployeeModel, Employee>();
            CreateMap<Employee, EmployeeModel>();

            CreateMap<GetEmployeeList, EmployeeModel>();
            CreateMap<GetEmployeeById,EmployeeModel>();

            CreateMap<CreateEmployeeCommand, Employee>();
            CreateMap<UpdateEmployeeCommand, Employee>();
        }
    }
}
