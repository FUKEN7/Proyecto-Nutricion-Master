using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class personServices
    {
        private readonly personaRepository personaRepository;
        private readonly deportistaRepository deportistaRepository;
        public personServices()
        {
            personaRepository = new personaRepository();
            deportistaRepository = new deportistaRepository();
        }

        //Metodo de servicio de login
        public bool LoginPerson(string email,string password)
        {
            try
            {
                personaRepository.ConnectionDB.Open();
                return personaRepository.Login(email, password);
            }
            catch (Exception)
            {
                return false;
            }finally { personaRepository.ConnectionDB.Close();}
        }
        //Metodo de consulta
        public ConsultarPersonaRespuesta consultarTodo()
        {
            ConsultarPersonaRespuesta respuesta = new ConsultarPersonaRespuesta();
            try
            {
                personaRepository.ConnectionDB.Open();
                respuesta.Personas = personaRepository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Personas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { personaRepository.ConnectionDB.Close(); }
        }


    }
    public class ConsultarPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Persona> Personas { get; set; }
    }
}
