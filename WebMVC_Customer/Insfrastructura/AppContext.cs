using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Insfrastructura
{
   public class AppContext :DbContext, IRepository
    {
       public AppContext()
           : base("DefaultConnection")
       {

       }
       
       public IDbSet<Cliente> Cliente { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           var conexion = this.Database.Connection.ConnectionString;

           modelBuilder.Configurations.Add(new Configuracion.ConfigAppContext());
           base.OnModelCreating(modelBuilder);
       }

       
    }
}
