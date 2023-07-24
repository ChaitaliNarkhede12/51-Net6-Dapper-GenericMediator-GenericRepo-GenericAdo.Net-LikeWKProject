using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Data.SqlConnections.Interfaces
{
    public interface ISqlConnectionProvider
    {
        Task<SqlConnector> GetCatalogConnection();

        Task<SqlConnector> GetDatabaseConnection();
    }
}
