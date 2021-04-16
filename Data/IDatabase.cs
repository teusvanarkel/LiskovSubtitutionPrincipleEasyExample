using System.Collections.Generic;
using LiskovSubstitutionExample.Models;

namespace Data
{
    public interface IDatabase<T> where T : class
    {
        void Add(T model);
        void Delete(T model);
        List<T> GetAll();
        T GetById<TPrimaryKey>(TPrimaryKey id);
        void Update(T model);
    }
}