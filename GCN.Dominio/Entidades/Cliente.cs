using GCN.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Dominio
{
    public class Cliente : Entidade
    {
        public Cliente()
        {

        }

        public Cliente(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
