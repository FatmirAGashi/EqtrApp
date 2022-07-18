using EqtrApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqtrApp.DataAccess.Repositories.Abstractions
{
    public interface IRepository<T> where T : BaseModel
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(int id);
        void Save();

    }
}
