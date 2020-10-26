using GCN.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework.Mapeamentos
{
    public class MapeamentoDeCliente : EntityTypeConfiguration<Cliente>
    {
        public MapeamentoDeCliente()
        {
            this.ToTable("Clientes");
        }
    }
}
