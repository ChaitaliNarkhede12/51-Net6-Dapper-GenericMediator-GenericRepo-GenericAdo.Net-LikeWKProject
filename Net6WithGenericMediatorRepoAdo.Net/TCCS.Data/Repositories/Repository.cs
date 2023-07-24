using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Data.Inerfaces;
using TCCS.Data.SqlConnections.Interfaces;

namespace TCCS.Data.Repositories
{
    public class Repository : IRepository
    {
        private readonly ISqlConnectionProvider _connectionProvider;

        private readonly ISqlCommandWrapper _sqlCommandWrapper;

        public Repository(ISqlConnectionProvider connectionProvider,
            ISqlCommandWrapper sqlCommandWrapper)
        {
            _connectionProvider = connectionProvider;
            _sqlCommandWrapper = sqlCommandWrapper;
        }

        public async Task<IEnumerable<T>> GetList<T>()
        {
            var sqlConnector = await _connectionProvider.GetDatabaseConnection().ConfigureAwait(false);

            var result = await _sqlCommandWrapper.QueryAllAsync<T>(sqlConnector,null).ConfigureAwait(false);

            return result;

        }

        public async Task<T> GetById<T>(DynamicParameters parameters)
        {
            var sqlConnector = await _connectionProvider.GetDatabaseConnection().ConfigureAwait(false);

            var result = await _sqlCommandWrapper.QueryAsync<T>(sqlConnector, parameters).ConfigureAwait(false);

            return result;
        }

        public async Task<int> AddAsync<T>(DynamicParameters parameters)
        {
            var sqlConnector = await _connectionProvider.GetDatabaseConnection().ConfigureAwait(false);

            var result = await _sqlCommandWrapper.ExecuteAsync<T>(sqlConnector, parameters).ConfigureAwait(false);

            return result;
        }

        public async Task<int> UpdateAsync<T>(DynamicParameters parameters)
        {
            var sqlConnector = await _connectionProvider.GetDatabaseConnection().ConfigureAwait(false);

            var result = await _sqlCommandWrapper.ExecuteAsync<T>(sqlConnector, parameters).ConfigureAwait(false);

            return result;
        }

        public async Task<int> RemoveAsync<T>(DynamicParameters parameters)
        {
            var sqlConnector = await _connectionProvider.GetDatabaseConnection().ConfigureAwait(false);

            var result = await _sqlCommandWrapper.ExecuteAsync<T>(sqlConnector, parameters).ConfigureAwait(false);

            return result;
        }

        
    }
}
