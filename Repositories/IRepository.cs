using System.Collections.Generic;

namespace Repositories
{
    public interface IRepository<T>
    {
        void Add(T model);

        void Delete(T model);

        void Update(T model);

        List<T> GetAll();
    }
}