using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Data.Inerfaces;
using TCCS.Domain.Interfaces;
using TCCS.Domain.Models.Employees;
using static Dapper.SqlMapper;

namespace TCCS.Domain.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IRepository _repo;

        public EmployeeRepository(IRepository repo)
        {
            _repo = repo;
        }

        //public async Task<IEnumerable<Employee>> GetList<Employee>()
        //{
        //    var res = await _repo.GetList<Employee>();
        //    return res; ;
        //}

        //public async Task<Employee> GetById<Employee>(int id)
        //{
        //    var res = await _repo.GetById<Employee>(id);
        //    return res;
        //}

        public async Task<IEnumerable<GetEmployeeList>> GetList<GetEmployeeList>()
        {
            var res = await _repo.GetList<GetEmployeeList>();
            return res;
        }

        public async Task<GetEmployeeById> GetById<GetEmployeeById>(int id)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("Id", id, System.Data.DbType.String);

            var res = await _repo.GetById<GetEmployeeById>(dbParameter);
            return res;
        }



        public async Task<int> Addsync<AddEmployee>(Employee entity)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("Name", entity.Name, System.Data.DbType.String);
            dbParameter.Add("City", entity.City, System.Data.DbType.String);

            var res = await _repo.AddAsync<AddEmployee>(dbParameter);
            return res;
        }

        public async Task<int> Updatesync<UpdateEmployee>(Employee entity)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("Id", entity.Id, System.Data.DbType.Int32);
            dbParameter.Add("Name", entity.Name, System.Data.DbType.String);
            dbParameter.Add("City", entity.City, System.Data.DbType.String);

            var res = await _repo.UpdateAsync<UpdateEmployee>(dbParameter);
            return res;
        }

        public async Task<int> RemoveAsync<RemoveEmployee>(int id)
        {
            var dbParameter = new DynamicParameters();
            dbParameter.Add("Id", id, System.Data.DbType.Int32);

            var res = await _repo.RemoveAsync<RemoveEmployee>(dbParameter);
            return res;
        }
    }
}
