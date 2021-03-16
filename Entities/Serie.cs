using DioSeries.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioSeries.Entities
{
    public class Serie : Entity
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public Serie(Guid id) : base(id)
        {
        }
        public override string ToString()
        {

            return $"Genero: {this.Genero} {Environment.NewLine}" +
                $"Título: {this.Genero} {Environment.NewLine}" +
                $"Descrição {this.Descricao} {Environment.NewLine}" +
                $"Ano de Início {this.Ano} {Environment.NewLine}";
        }

    }
}
