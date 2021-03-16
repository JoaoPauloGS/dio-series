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
        ICollection<T> List();
        T Get(Guid id);
        Task Insert(T entity);
        Task Delete(Guid id);
        Task Update(Guid id, T entity);
        Task<bool> Commit();
    }
}
