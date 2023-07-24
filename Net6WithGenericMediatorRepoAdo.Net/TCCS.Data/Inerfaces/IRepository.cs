using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Data.Inerfaces
{
    public interface IRepository
    {
        Task<IEnumerable<T>> GetList<T>();

        Task<T> GetById<T>(DynamicParameters parameters);

        Task<int> AddAsync<T>(DynamicParameters parameters);

        Task<int> UpdateAsync<T>(DynamicParameters parameters);

        Task<int> RemoveAsync<T>(DynamicParameters parameters);
    }
}
