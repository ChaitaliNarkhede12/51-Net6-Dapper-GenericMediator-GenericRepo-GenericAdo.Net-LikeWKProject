using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TCCS.Data.SqlConnections.Interfaces;

namespace TCCS.Data.SqlConnections
{
    public class SqlCommandWrapper : ISqlCommandWrapper
    {
        public async Task<List<T>> QueryAllAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure)
        {
            var spName = GetStoredProcedureName(typeof(T)); 

            using(var conn = sqlConnector.SqlConnection)
            {
                var res = (List<T>)await conn.QueryAsync<T>(spName,parameters,commandType:cmdType).ConfigureAwait(false);
                return res;
            }
        }

        public async Task<T> QueryAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure)
        {
            var spName = GetStoredProcedureName(typeof(T));

            using (var conn = sqlConnector.SqlConnection)
            {
                var res = (List<T>) await conn.QueryAsync<T>(spName, parameters, commandType: cmdType).ConfigureAwait(false);
                return res.FirstOrDefault();
            }
        }

        public async Task<int> ExecuteAsync<T>(SqlConnector sqlConnector, DynamicParameters parameters, CommandType cmdType = CommandType.StoredProcedure)
        {
            var spName = GetStoredProcedureName(typeof(T));

            using (var conn = sqlConnector.SqlConnection)
            {
                return await conn.ExecuteAsync(spName,parameters,commandType:cmdType).ConfigureAwait(false);
            }
        }


        public string GetStoredProcedureName(Type t)
        {
            var customAttribute = t.GetCustomAttributes().OfType<StoredProcedureNameAttribute>().FirstOrDefault();  

            if(customAttribute == null)
            {
                throw new ArgumentException($"no stored procedure name for {t}");
            }

            var storeProcedureName = (StoredProcedureNameAttribute)customAttribute;

            return storeProcedureName.SqlStoredProcedureName;
        }

       
    }
}
