using CapaDataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Implementations
{
    public class GenericRepository<C, T> :
    IGenericRepository<T> where T : class where C : DbContext, new()
    {

        private C _entities = new C();
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public T Get(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
