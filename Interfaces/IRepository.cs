using DioSeries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeries.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        List<T> List();
        T Get(Guid id);
        void Insert(T entity);
        void Delete(Guid id);
        void Update(Guid id, T entity);
        bool Commit();
    }
}
