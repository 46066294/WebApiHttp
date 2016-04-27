using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Insfrastructura.Configuracion
{
    public class ConfigAppContext : EntityTypeConfiguration<Insfrastructura.AppContext>
    {
        public ConfigAppContext()
        {

        }
    }
}
