using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Data.SqlClient;

namespace Logica
{
    public class ServicePlantilla
    {
        PlantillaRepository repository;
        public ServicePlantilla()
        {
            repository = new PlantillaRepository();
        }


        public string Guardar(Plantilla plantilla)
        {
            try
            {
                repository.connection.Open();
                repository.Guardar(plantilla);
                return "Plantilla Guardada";
            }
            catch(Exception e)
            {
                return $"Error al guardar los datos {e.Message}";
            }
            finally { repository.connection.Close();}
        }

        public string AddGuardarPlantilla(Plantilla plantilla)
        {
            try
            {
                repository.connection.Open();
                repository.GuardarPlantillaAlimento(plantilla);
                return "Agregado con Exito";
            }
            catch (Exception e)
            {
                return "Error"+e.Message;
            }finally { repository.connection.Close(); }
        }


        public ConsultarRespuestaPlantilla Consultar()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            try
            {
                repository.connection.Open();
                respuesta.Plantillas = repository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Plantillas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch(Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }finally { repository.connection.Close(); }
        }
        public ConsultarRespuestaPlantilla ConsultarPlantilla()
        {
            ConsultarRespuestaPlantilla respuesta = new ConsultarRespuestaPlantilla();
            try
            {
                repository.connection.Open();
                respuesta.Plantillas = repository.ConsultarPlantilla();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Plantillas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { repository.connection.Close(); }
        }

    }

    public class ConsultarRespuestaPlantilla
    {
        public IList<Plantilla> Plantillas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
    }

}
