
using Entidad;
using Logica;
using NUnit.Framework;

namespace Pruebas
{
    public class PruebasPlantillas
    {
        ServicePlantilla servicePlantilla;
        Plantilla plantilla;
        [SetUp]
        public void Setup()
        {
            servicePlantilla = new ServicePlantilla();
            plantilla = new Plantilla();
        }

        //Crear plantilla
        [Test]
        public void TestAgregarPlantilla()
        {
            plantilla.NombrePlantilla = "SEMANA 1";
            string result = servicePlantilla.Guardar(plantilla);
            string esperado = "Plantilla Guardada";
            Assert.AreEqual(result, esperado);
            Assert.Pass();
        }

        //Agregar a plantilla alimento 
        [Test]
        public void TestAgregarAlimentosPlantilla()
        {
            plantilla.NombrePlantilla = "SEMANA 1";
            plantilla.Categoria = "Desayuno";
            plantilla.Porcion = 1;
            plantilla.idAlimento = "142";
            string result = servicePlantilla.AddGuardarPlantilla(plantilla);
            string esperado = "Agregado con Exito";
            Assert.AreEqual (esperado,result);
            Assert.Pass();
        }
    }
}
