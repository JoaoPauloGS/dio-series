using DioSeries.Entities;
using DioSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DioSeries.Data
{
    public class SerieData : IData<Serie>
    {
        public async Task<ICollection<Serie>> Get()
        {
            using FileStream openStream = File.OpenRead("series.json");
            return await JsonSerializer.DeserializeAsync<ICollection<Serie>>(openStream);
        }

        public async Task Save(ICollection<Serie> entites)
        {
            using FileStream createStream = File.Create("series.json");
            await JsonSerializer.SerializeAsync(createStream, entites);
        }
    }
}
