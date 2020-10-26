using GCN.Dominio;
using GCN.Infraestrutura.InterfaceDeServicosExternos;
using GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Aplicacao.GestaoDeClientes
{
    public class ServicoDeGestaoDeClientes : IServicoDeGestaoDeClientes
    {
        private readonly IServicoExternoDePersistenciaViaEntityFramework _servicoExternoDePersistencia;
   
        public ServicoDeGestaoDeClientes(IServicoExternoDePersistenciaViaEntityFramework servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public void CadastrarNovoCliente(string nome, string telefone)
        {
            if (this._servicoExternoDePersistencia.RepositorioDeClientes.VerificaSeJaCliente(nome))
            {
                var novoCliente = new Cliente(nome, telefone);
                this._servicoExternoDePersistencia.Persistir();
            }
        }
    }
}
