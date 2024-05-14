using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Plantilla
    {
        public string NombrePlantilla { get; set; }
        public int Porcion { get; set; }
        public string Categoria { get; set; }
        public string Ingrediente { get; set; }
        public string idDieta { get; set; }
        public string idAlimento { get; set; }
        public List<Dieta> dietas { get; set; }
        public List<Alimento> Alimentos { get; set; }

        public void AgregarDieta(Dieta dieta)
        {
            dieta.IdDieta = idDieta;
            dietas.Add(dieta);
        }

        public void AgregarAlimentos(Alimento alimento)
        {
            alimento.IdAlimentos = idAlimento;
            Alimentos.Add(alimento);
        }

    }
}
