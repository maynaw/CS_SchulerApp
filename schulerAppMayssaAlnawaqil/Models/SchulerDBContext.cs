using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace schulerAppMayssaAlnawaqil.Models
{
    internal class SchulerDBContext : DbContext
    {
        public DbSet<Schuler> Schueler { get; set; }
    }
}
