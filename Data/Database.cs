using System.Collections.Generic;
using LiskovSubstitutionExample.Models;

namespace Data
{

    public class Database<T> : IDatabase<T> where T : class
    {
        private List<T> memory = new List<T>();
        public void Add(T model)
        {
            memory.Add(model);
        }

        public void Delete(T model)
        {
            memory.Remove(model);
        }

        public void Update(T model)
        {
            Delete(model);
            Add(model);
        }

        public List<T> GetAll()
        {
            return memory;
        }

        public T GetById<TPrimaryKey>(TPrimaryKey id)
        {
            return null;
        }

    }
}