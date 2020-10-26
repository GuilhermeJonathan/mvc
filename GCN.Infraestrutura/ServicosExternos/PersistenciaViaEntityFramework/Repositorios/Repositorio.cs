using GCN.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCN.Dominio.Repositorios;

namespace GCN.Infraestrutura.ServicosExternos.PersistenciaViaEntityFramework.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        protected readonly Contexto _contexto;
        public Repositorio(Contexto contexto)
        {
            this._contexto = contexto;
        }

        public void Alterar(int id, T novoItem)
        {
            this._contexto.Entry<T>(novoItem).State = System.Data.Entity.EntityState.Modified;
        }

        public T BuscarPorId(int id)
        {
            return this._contexto.Set<T>().Find(id);
        }

        public T Inserir(T item)
        {
            return _contexto.Set<T>().Add(item);
        }

        public IEnumerable<T> Inserir(IEnumerable<T> item)
        {
            return _contexto.Set<T>().AddRange(item);
        }

        public IEnumerable<T> Listar()
        {
            return this._contexto.Set<T>().ToList();
        }

        public void Persistir()
        {
            this._contexto.SaveChanges();
        }

    }
}
