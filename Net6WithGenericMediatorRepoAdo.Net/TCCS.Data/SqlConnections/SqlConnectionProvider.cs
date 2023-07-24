using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Data.Extensions;
using TCCS.Data.Models;
using TCCS.Data.SqlConnections.Interfaces;

namespace TCCS.Data.SqlConnections
{
    public class SqlConnectionProvider : ISqlConnectionProvider
    {
        private readonly DatabaseConnectionWithoutCredentials _databaseConnection;

        public SqlConnectionProvider(DatabaseConnectionWithoutCredentials databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public async Task<SqlConnector> GetCatalogConnection()
        {
            var connection = await _databaseConnection.GetConnectionForDataBaseWithoutCredentials(_databaseConnection.DatabaseName);
            return new SqlConnector { SqlConnection = connection };
        }

        public async Task<SqlConnector> GetDatabaseConnection()
        {
            var connection = await _databaseConnection.GetConnectionForDataBaseWithoutCredentials(_databaseConnection.DatabaseName);
            return new SqlConnector { SqlConnection = connection };
        }
    }
}
