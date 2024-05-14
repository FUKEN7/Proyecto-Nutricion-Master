using System;
using System.Collections.Generic;
using Entidad;
using Datos;

namespace Logica
{
    public class serviceDeportista
    {
        private readonly deportistaRepository deportistaRepository;
        public serviceDeportista()
        {
            deportistaRepository = new deportistaRepository();
        }
        //Metodo de Crear Desportista
        public string Guardar(Deportista deportista)
        {
            try
            {
                string mensajeEmail = string.Empty;
                CorreoService correo = new CorreoService();
                deportista.CalculoGastoEnergeticoDiario();
                deportistaRepository.connection.Open();
                if (deportistaRepository.ConsultarPorId(deportista.id)==null)
                {
                    deportistaRepository.SavePerson(deportista);
                    deportistaRepository.Guardar(deportista);
                    return "Paciente Registrado";
                }
                else
                {
                    return "El usuario ya existe";
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { deportistaRepository.connection.Close(); }
        }
        //Metodo Consultar
        public ConsultarClienteRespuesta ConsultarTodos()
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            try
            {

                deportistaRepository.connection.Open() ;
                respuesta.Deportistas = deportistaRepository.Consultar();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { deportistaRepository.connection.Close(); }
        }
        //Metodo guardar Dieta
        public string GuardarDieta(Dieta dieta)
        {
            try
            {
                deportistaRepository.connection.Open();
                deportistaRepository.GuardarRecomendaciones(dieta);
                return "DATOS GUARDADOS";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { deportistaRepository.connection.Close(); }
        }

        //Metodo Buscar por id
        public ConsultarClienteRespuesta BuscarPorId(string id)
        {
            ConsultarClienteRespuesta respuesta = new ConsultarClienteRespuesta();
            try
            {
                deportistaRepository.connection.connectionDB.Open();
                respuesta.Deportistas = deportistaRepository.FiltrarPorId(id);
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception)
            {
                return null;
            }
            finally { deportistaRepository.connection.connectionDB.Close(); }
        }
        //Metodo de Busqueda por Nombre
        public ConsultarClienteRespuesta BuscarPorNombre(string nombre)
        {
            ConsultarClienteRespuesta respose = new ConsultarClienteRespuesta();
            try
            {
                deportistaRepository.connection.connectionDB.Open();
                respose.Deportistas = deportistaRepository.FiltrarPorNombre(nombre);
                respose.Mensaje = (respose.Deportistas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                respose.Error = false;
                return respose;
            }
            catch (Exception)
            {

                throw;
            }
            finally { deportistaRepository.connection.connectionDB.Close(); }
        }
        //Editar Deportista
        public string EditarDeportista(Deportista deportista,string id)
        {
            try
            {
                deportistaRepository.connection.Open();
                if (deportistaRepository.FiltrarPorId(id)!=null)
                {
                    deportistaRepository.EditarPerson(deportista,id);
                    return "Usuario Editado Correctamente";
                }
                else
                {
                    return "El usuario no exite";
                }
                
            }
            catch (Exception e)
            {

                return "Error de la aplicacion: " + e.Message;
            }
            finally { deportistaRepository.connection.Close(); }
        }

        //Eliminer Deportista
        public string EliminarDeportista(string id)
        {
            try
            {
                deportistaRepository.connection.Open();
                if (deportistaRepository.ConsultarPorId(id)!=null)
                {
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportistaRepository.EliminarDieta(id);
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportistaRepository.EliminarDeportista(id);
                    deportistaRepository.connection.Close();
                    deportistaRepository.connection.Open();
                    deportistaRepository.EliminarPersona(id);
                    return "Usuario Eliminado";
                }
                else
                {
                    return "Usuario No encontrado";
                }
                
            }
            catch (Exception e)
            {

                return "Error de Aplicacion: " + e.Message;
            }
            finally { deportistaRepository.connection.Close(); }
        }

        //Metodo de Consultar Dieta
        public ConsultarDietaRespuesta ConsultarDieta(string id)
        {
            ConsultarDietaRespuesta respuesta = new ConsultarDietaRespuesta();
            try
            {
                deportistaRepository.connection.connectionDB.Open();
                respuesta.Dietas = (IList<Dieta>)deportistaRepository.ConsultaDieta(id);
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Dietas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception)
            {
                return null;
            }
            finally { deportistaRepository.connection.connectionDB.Close(); }
        }


    }


    public class ConsultarDietaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Dieta> Dietas { get; set; }
    }

    public class ConsultarDeportista
    {
        public List<Deportista> Deportistas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultarDeportista(List<Deportista> deportistas)
        {
            Deportistas = deportistas;
            Error = false;
        }

        public ConsultarDeportista(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }

    public class ConsultarClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Deportista> Deportistas { get; set; }
    }

}
