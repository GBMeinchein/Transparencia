using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransparenciaEntities
{
    public class DbEntities : DbContext
    {
        public DbEntities()
            : base("name=SqlConnect")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
    }
}
