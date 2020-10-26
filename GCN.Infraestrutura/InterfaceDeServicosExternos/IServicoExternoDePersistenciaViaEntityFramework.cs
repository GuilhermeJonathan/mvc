using GCN.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Infraestrutura.InterfaceDeServicosExternos
{
    public interface IServicoExternoDePersistenciaViaEntityFramework
    {
        IRepositorioDeClientes RepositorioDeClientes { get; }
        void Persistir();
        void Dispose();
    }
}
