using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Data.SqlConnections
{
    [AttributeUsage(AttributeTargets.All)]
    public class StoredProcedureNameAttribute : Attribute
    {
        private readonly string spName;

        public StoredProcedureNameAttribute(string name)
        {
            spName = name;
        }

        public string SqlStoredProcedureName => spName;
    }
}
