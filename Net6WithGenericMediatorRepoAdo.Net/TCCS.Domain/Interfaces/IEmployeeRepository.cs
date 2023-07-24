using TCCS.Domain.Models.Employees;

namespace TCCS.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        //Task<IEnumerable<Employee>> GetList<Employee>();
        //Task<Employee> GetById<Employee>(int id);

        Task<IEnumerable<GetEmployeeList>> GetList<GetEmployeeList>();

        Task<GetEmployeeById> GetById<GetEmployeeById>(int id);

        Task<int> Addsync<AddEmployee>(Employee entity);

        Task<int> Updatesync<UpdateEmployee>(Employee entity);

        Task<int> RemoveAsync<RemoveEmployee>(int id);
    }
}
