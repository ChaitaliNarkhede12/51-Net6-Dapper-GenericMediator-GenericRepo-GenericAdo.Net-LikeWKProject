using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Data.SqlConnections.Interfaces
{
    public interface ISqlCommandWrapper
    {
        Task<List<T>> QueryAllAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure);         

        Task<T> QueryAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure); 
    
        Task<int> ExecuteAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure);

        string GetStoredProcedureName(Type t);
    }
}
