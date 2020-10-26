using GCN.Dominio.Repositorios;
using GCN.Infraestrutura.InterfaceDeServicosExternos;
using GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework
{
    public class ServicoExternoDePersistenciaViaEntityFramework : IServicoExternoDePersistenciaViaEntityFramework
    {
        private readonly Contexto _contexto;

        public ServicoExternoDePersistenciaViaEntityFramework(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public IRepositorioDeClientes RepositorioDeClientes
        {
            get
            {
                return new RepositorioDeClientes(this._contexto);
            }
        }

        public void Persistir()
        {
            this._contexto.SaveChanges();
        }

        public void Dispose()
        {
            if (this._contexto != null)
                this._contexto.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
