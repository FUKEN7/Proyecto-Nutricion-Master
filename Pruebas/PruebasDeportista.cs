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
    public class PruebasDeportista
    {
        serviceDeportista service;
        Deportista deportista;
        [SetUp]
        public void Setup()
        {
            service = new serviceDeportista();
            deportista = new Deportista();
        }
        //Crear Deportista
        [Test]
        public void TestGuardarDeportista()
        {
            deportista.TipoId = "CEDULA CIUDADANIA";
            deportista.id = "1234567891";
            deportista.Nombre = "Mario";
            deportista.Apellidó = "de la cruz";
            deportista.Fecha_Nacimiento = DateTime.Parse("12-04-1999");
            deportista.Correo = "d@gmail.com";
            deportista.Password = "gdsaysdsa";
            deportista.Telefono = "316554586";
            deportista.Sexo = "M";
            deportista.Peso = 65;
            deportista.Altura = 172.5;
            deportista.Deporte = "Futball";
            deportista.TermogenesisActividadFisica = "Extremo";
            deportista.FechaEgreso = DateTime.Now;
            string result = service.Guardar(deportista);
            string esperado = "Paciente Registrado";
            Assert.AreEqual(esperado, result);
            Assert.Pass();
        }

    }
}
