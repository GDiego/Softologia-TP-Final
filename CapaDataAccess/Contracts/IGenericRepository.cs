using System.Collections.Generic;
using System.Linq;

namespace CapaDataAccess.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Remove(T entity);

        void Edit(T entity);

        void Save();
    }
}