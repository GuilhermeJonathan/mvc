using GCN.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCN.Dominio.Repositorios
{
    public interface IRepositorio<T> where T : Entidade
    {
        T BuscarPorId(int id);
        IEnumerable<T> Listar();
        T Inserir(T item);
        IEnumerable<T> Inserir(IEnumerable<T> item);
        void Alterar(int id, T novoItem);
        void Persistir();
    }
}
