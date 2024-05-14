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
    public class serviceAlimento
    {
        public AlimentoRepository alimentoRepository;

        public serviceAlimento()
        {
            alimentoRepository = new AlimentoRepository();
        }

        public ConsultarAlimentoRespuesta consultarTodo()
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                alimentoRepository.connection.Open();
                respuesta.Alimentos = alimentoRepository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { alimentoRepository.connection.Close(); }
        }

        public string Guardar(Alimento alimento)
        {
            try
            {
                alimentoRepository.connection.Open();
                if (alimentoRepository.BuscarIdAlimento(alimento.IdAlimentos) == null)
                {
                    alimentoRepository.Guardar(alimento);
                    return "Alimento Guardado";
                }
                else
                {
                    return $"Ya Existe este alimento";
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { alimentoRepository.connection.Close(); }

        }

        public ConsultarAlimentoRespuesta consultarPorId(string id)
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                alimentoRepository.connection.Open();
                respuesta.Alimentos = (IList<Alimento>)alimentoRepository.BuscarIdAlimento(id);
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { alimentoRepository.connection.Close(); }
        }

        public ConsultarAlimentoRespuesta FiltrarPorNombre(string nombre)
        {
            ConsultarAlimentoRespuesta respuesta = new ConsultarAlimentoRespuesta();
            try
            {
                alimentoRepository.connection.Open();
                respuesta.Alimentos = alimentoRepository.FiltrarConsulta(nombre);
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Alimentos.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { alimentoRepository.connection.Close(); }
        }


    }

    public class ConsultarAlimentoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Alimento> Alimentos { get; set; }
    }


}
