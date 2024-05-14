using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Alimento
    {
        public Alimento()
        {
            Carbohidratos = 0;
            Proteinas = 0;
            Liquidos = 0;
            Calorias = 0;
        }

        public string IdAlimentos { get; set; }
        public string NombreAlimento { get; set; }
        public double Calorias { get; set; }
        public double Carbohidratos { get; set; }
        public double Proteinas { get; set; }
        public double Liquidos { get; set; }
        public string IdDietas { get; set; }
    }
}
