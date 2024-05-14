using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Deportista : Persona
    {
        public Deportista()
        {
            Peso = 0;
            Altura = 0;
            CaloriasDiarias = 0;
            MetabolismoBasal = 0;
            ActividadFisica = 0;
            CalcularEdad();
        }
        public string Deporte { get; set; }
        public string TermogenesisActividadFisica { get; set; }
        public DateTime FechaEgreso { get; set; }
        public double Peso { get; set; }
        public double PesoActual { get; set; }
        public double Altura { get; set; }
        public double CaloriasDiarias { get; set; }
        public double MetabolismoBasal { get; set; }
        public double ActividadFisica { get; set; }
        public Dieta Dieta { get; set; }

        public void CalculoGastoEnergeticoDiario()
        {
            Dieta dieta = new Dieta();
            CalcularActividadFisica();
            CalcularMetabolismoBasal();
            dieta.MetodoAccinDinamicaEspecificaAlimentos();
            
            if (Sexo == "M")
            {
                CaloriasDiarias = (66.5 + (13.75 * Peso) + (5.08 * Altura) - (6.78 * (Edad-Fecha_Nacimiento.Year)) + dieta.AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
                
            }
            else
            {
                if (Sexo == "F")
                {
                    CaloriasDiarias = (65.51 + (9.56 * Peso) + (1.85 * Altura) - (4.68 * (Edad-Fecha_Nacimiento.Year)) + dieta.AcciónDinámicaEspecíficaAlimentos + ActividadFisica);
                }

            }

        }

        private void CalcularMetabolismoBasal()
        {
            MetabolismoBasal = 24 * Peso;
        }

        private void CalcularActividadFisica()
        {
            if (TermogenesisActividadFisica.Equals("LEVE"))
            {
                ActividadFisica = 0.2;
            }

            if (TermogenesisActividadFisica.Equals("MODERADA"))
            {
                ActividadFisica = 0.3;
            }
            if (TermogenesisActividadFisica.Equals("INTENSA"))
            {
                ActividadFisica = 0.4;
            }
            if (TermogenesisActividadFisica.Equals("EXTREMA"))
            {
                ActividadFisica = 1;
            }
        }

        public void CalcularEdad()
        {
            Edad = DateTime.Now.Year;
        }
    }
}
