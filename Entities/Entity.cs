using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeries.Entities
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = id;
            Excluded = false;
        }

        public Guid Id { get; set; }
        public bool Excluded { get; set; }
        public void Delete()
        {
            this.Excluded = true;
        }
    }
}
