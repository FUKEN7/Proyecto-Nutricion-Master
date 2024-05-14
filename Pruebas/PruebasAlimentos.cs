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
    public class PruebasAlimentos
    {
        serviceAlimento service;
        Alimento alimento;
        [SetUp]
        public void Setup()
        {
            service = new serviceAlimento();
            alimento = new Alimento();
        }
        //Agregar Alimento
        [Test]
        public void TestAgregarAlimentos()
        {
            alimento.IdAlimentos = "1505225";
            alimento.NombreAlimento = "juan";
            alimento.Carbohidratos = 42;
            alimento.Proteinas = 20;
            alimento.Calorias = 2.2;
            alimento.Liquidos = 3.2;
            string result = service.Guardar(alimento);
            string esperado = "Alimento Guardado";
            Assert.AreEqual(esperado,result);
            Assert.Pass();
        }

    }
}
