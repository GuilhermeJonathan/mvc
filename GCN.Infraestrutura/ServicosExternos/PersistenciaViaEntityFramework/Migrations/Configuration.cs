using GCN.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            MigrationsDirectory = @"ServicosExternos/PersistenciaViaEntityFramework/Migrations";
        }

        protected override void Seed(Contexto contexto)
        {
            var cliente = new Cliente("teste", "teste'121");
            contexto.Set<Cliente>().Add(cliente);
            contexto.SaveChanges();
        }

    }
}
