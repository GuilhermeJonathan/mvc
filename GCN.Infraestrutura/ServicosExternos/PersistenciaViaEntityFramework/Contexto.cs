using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework
{
    public class Contexto : DbContext
    {
        public Contexto() : base(ConfigurationManager.ConnectionStrings["conexaoDoBanco"].ConnectionString)
        {  
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
