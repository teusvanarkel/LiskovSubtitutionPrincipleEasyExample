using System.Collections.Generic;
using Data;

namespace Repositories
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly IDatabase<T> _database;
        public Repository()
        {
            _database = new Database<T>();
        }
        public void Add(T model)
        {
            _database.Add(model);
        }

        public void Delete(T model)
        {
            _database.Delete(model);
        }

        public void Update(T model)
        {
            _database.Update(model);
        }

        public List<T> GetAll()
        {
            return _database.GetAll();
        }
    }
}