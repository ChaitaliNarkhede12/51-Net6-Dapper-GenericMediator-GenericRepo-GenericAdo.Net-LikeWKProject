using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCS.Data.SqlConnections;

namespace TCCS.Domain.Models.Employees
{
    [StoredProcedureName("[dbo].[UpdateEmployee]")]
    public class UpdateEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
