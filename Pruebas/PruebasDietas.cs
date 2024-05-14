using Entidad;
using Logica;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class PruebasDietas
    {
        serviceDeportista service;
        Dieta dietas;
        [SetUp]
        public void Setup()
        {
            service = new serviceDeportista();
            dietas = new Dieta();
        }
        //Crear Recomendacion
        [Test]
        public void AgregarRecomendacion()
        {
            dietas.DiasAplicados = "Lunes";
            dietas.RecomendacionAlimentaria = "Tomar mas agua";
            dietas.RecomendacionNutriccional = "Llevar un buen ejercicios";
            dietas.identificacion = "1063600356";
            dietas.plantillas = "SEMANA 1";

            string result = service.GuardarDieta(dietas);
            string esperado = "DATOS GUARDADOS";

            Assert.That(esperado, Is.EqualTo(result));
            Assert.Pass();
        }
    }
}
