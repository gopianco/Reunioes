using System;
using System.Collections.Generic;
using System.Linq;
using Reunioes.Dominio.Contratos;
using Reunioes.Repositorio.Contexto;

namespace Reunioes.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ReunioesContexto ReunioesContexto;
        public BaseRepositorio(ReunioesContexto reunioesContexto)
        {
            ReunioesContexto = reunioesContexto;
        }

        public void Adicionar(TEntity entity)
        {
            ReunioesContexto.Set<TEntity>().Add(entity);
            ReunioesContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ReunioesContexto.Set<TEntity>().Update(entity);
            ReunioesContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return ReunioesContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ReunioesContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ReunioesContexto.Remove(entity);
            ReunioesContexto.SaveChanges();
        }
        public void Dispose()
        {
            ReunioesContexto.Dispose();
        }
    }
}
