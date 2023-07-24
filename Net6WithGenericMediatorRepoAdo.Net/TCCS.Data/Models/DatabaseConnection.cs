using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.Data.Models
{
    public class DatabaseConnectionWithoutCredentials
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserIntegratedSecurity { get; set; }
        public string ConnectionStringTemplate { get; set; }
        public bool IsReadOnly { get; set; }

    }

    public class DatabaseConnectionWithCredentials
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserIntegratedSecurity { get; set; }
        public string UseSqlPassword { get; set; }
        public string SQLUserName { get; set; }
        public string SQPassword { get; set; }
        public string DevelopmentConnectionString { get; set; }
        public string ConnectionStringTemplate { get; set; }
        public bool IsReadOnly { get; set; }

    }
}
