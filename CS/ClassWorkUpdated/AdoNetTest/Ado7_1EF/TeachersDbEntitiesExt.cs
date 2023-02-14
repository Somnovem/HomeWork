using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado7_1EF
{
    public partial class TeachersDbEntities : DbContext
    {
        public TeachersDbEntities(string connectionString) : base(connectionString) { }
    }
}
