using DioSeries.Data;
using DioSeries.Entities;
using DioSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeries.Repositories
{
    public class SeriesRepository : IRepository<Serie>
    {
        private readonly SerieData _data;
        private readonly ICollection<Serie> _serieslist;
        public SeriesRepository()
        {
            _data = new SerieData();
            _serieslist = _data.Get().Result;
        }
        public async Task<bool> Commit()
        {
            await _data.Save(_serieslist);
            return true;
        }

        public async Task Delete(Guid id)
        {
            var serie = _serieslist.FirstOrDefault(s => s.Id == id);
            serie.Delete();
            await Commit();
        }

        public async Task<Serie> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Serie serie)
        {
            _serieslist.Add(serie);
            await Commit();
        }

        public async Task<ICollection<Serie>> List()
        {
            return _serieslist;
        }

        public async Task Update(Guid id, Serie entity)
        {
            var serie = _serieslist.FirstOrDefault(s => s.Id == id);
            serie.Ano = entity.Ano;
            serie.Descricao = entity.Descricao;
            serie.Genero = entity.Genero;
            serie.Titulo = entity.Titulo;

            await Commit();
        }
    }
}
