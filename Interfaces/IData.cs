using DioSeries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeries.Interfaces
{
    public interface IData<T> where T : Entity
    {
        public Task<ICollection<T>> Get();
        public Task Save(ICollection<T> entites);
    }
}
