using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Aplicacao.GestaoDeClientes
{
    public interface IServicoDeGestaoDeClientes
    {
        void CadastrarNovoCliente(string nome, string telefone);
    }
}
