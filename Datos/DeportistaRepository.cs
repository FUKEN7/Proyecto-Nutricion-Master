using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;
using System.Data.Common;

namespace Datos
{
    public class deportistaRepository
    {
        public readonly ConnectionDB connection = new ConnectionDB();

        //Crear Deportista
        public void Guardar(Deportista deportista)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"insert into Deportista(id,peso,altura,deporte,pesoActual,fechaEgreso,caloriasDiarias,metabolismoBasal,termogenesisActividadFisica)
                                                        values(@id,@peso,@altura,@deporte,@pesoActual,@fechaEgreso,@caloriasDiarias,@metabolismoBasal,@termogenesisActividadFisica)";
                command.Parameters.Add(new SqlParameter("@id", deportista.id));
                command.Parameters.Add(new SqlParameter("@peso", deportista.Peso));
                command.Parameters.Add(new SqlParameter("@altura", deportista.Altura));
                command.Parameters.Add(new SqlParameter("@deporte", deportista.Deporte));
                command.Parameters.Add(new SqlParameter("@pesoActual",deportista.PesoActual));
                command.Parameters.Add(new SqlParameter("@fechaEgreso", deportista.FechaEgreso));
                command.Parameters.Add(new SqlParameter("@caloriasDiarias", deportista.CaloriasDiarias));
                command.Parameters.Add(new SqlParameter("@metabolismoBasal", deportista.MetabolismoBasal));
                command.Parameters.Add(new SqlParameter("@termogenesisActividadFisica", deportista.TermogenesisActividadFisica));
                command.ExecuteNonQuery();
            }
        }

        //Metodo Guardar Persona
        public void SavePerson(Deportista persona)
        {
            using (var commands = connection.connectionDB.CreateCommand())
            {
                commands.CommandText = @"INSERT INTO Persona(id,tipoIdentificacion,nombre,apellido,sexo,fecha_Nacimiento,telefono,email,Password,role) 
                                                    VALUES(@id,@tipoIdentificacion,@nombre,@apellido,@sexo,@fecha_Nacimiento,@telefono,@email,@Password,@role)";
                commands.Parameters.Add(new SqlParameter("@id", persona.id));
                commands.Parameters.Add(new SqlParameter("@tipoIdentificacion", persona.TipoId));
                commands.Parameters.Add(new SqlParameter("@nombre", persona.Nombre));
                commands.Parameters.Add(new SqlParameter("@apellido", persona.Apellidó));
                commands.Parameters.Add(new SqlParameter("@sexo", persona.Sexo));
                commands.Parameters.Add(new SqlParameter("@fecha_Nacimiento", persona.Fecha_Nacimiento));
                commands.Parameters.Add(new SqlParameter("@telefono", persona.Telefono));
                commands.Parameters.Add(new SqlParameter("@email", persona.Correo));
                commands.Parameters.Add(new SqlParameter("@Password", persona.Password));
                commands.Parameters.Add(new SqlParameter("@role", persona.Rol));
                commands.ExecuteNonQuery();
            }
        }

        //Metodo de eliminar Persona
        public void EliminarPersona(string idD)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"DELETE Persona WHERE id=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", idD));
                command.ExecuteNonQuery();
            }
        }

        //Metodo de Eliminacion de deportista
        public void EliminarDeportista(string idD)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"DELETE Deportista WHERE id=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", idD));
                command.ExecuteNonQuery();
            }
        }

        //Metodo de Eliminacion de dieta
        public void EliminarDieta(string idD)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"DELETE Dieta WHERE idDeportista=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", idD));
                command.ExecuteNonQuery();
            }
        }
        //Metodo de consulta
        public List<Deportista> Consultar()
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.id = dataReader.GetString(0);
                    deportista.TipoId = dataReader.GetString(1);
                    deportista.Nombre = dataReader.GetString(2);
                    deportista.Apellidó = dataReader.GetString(3);
                    deportista.Sexo = dataReader.GetString(4);
                    deportista.Fecha_Nacimiento = dataReader.GetDateTime(5);//Agregado ultimo momento 
                    deportista.Telefono = dataReader.GetString(6);
                    deportista.Correo = dataReader.GetString(7);
                    deportista.Peso = dataReader.GetDouble(8);
                    deportista.Altura = dataReader.GetDouble(9);
                    deportista.Deporte = dataReader.GetString(10);
                    deportista.FechaEgreso = dataReader.GetDateTime(12);
                    deportista.CaloriasDiarias = dataReader.GetDouble(13);
                    deportista.MetabolismoBasal = dataReader.GetDouble(14);
                    deportista.TermogenesisActividadFisica = dataReader.GetString(15);
                    deportistas.Add(deportista);
                }
                dataReader.Close();
            }
            return deportistas;
        }

        //consultar todos SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0
        //Metodo de Buscar por Nombre
        public List<Deportista> FiltrarPorNombre(string nombre)
        {
            return (from p in Consultar()
                    where p.Nombre.ToLower().Contains(nombre.ToLower())
                    select p).ToList();
        }
        
        public void GuardarRecomendaciones(Dieta dieta)
        {
            using (var commnad = connection.connectionDB.CreateCommand())
            {
                commnad.CommandText = @"insert into Dieta(diasAplicada,recomendacionAlimentaria,recomendacionNutriccional,idDeportista,idPlantilla)
                                                    values(@diasAplicada,@recomendacionAlimentaria,@recomendacionNutriccional,@idDeportista,@idPlantilla)";
                commnad.Parameters.Add(new SqlParameter("@diasAplicada",dieta.DiasAplicados));
                commnad.Parameters.Add(new SqlParameter("@recomendacionAlimentaria", dieta.RecomendacionAlimentaria));
                commnad.Parameters.Add(new SqlParameter("@recomendacionNutriccional", dieta.RecomendacionNutriccional));
                commnad.Parameters.Add(new SqlParameter("@idDeportista", dieta.identificacion));
                commnad.Parameters.Add(new SqlParameter("@idPlantilla", dieta.plantillas));
                commnad.ExecuteNonQuery();
            }
        }

        //Metodo de buscar por id
        public List<Deportista> FiltrarPorId(string id)
        {
            return (from p in Consultar()
                    where p.id.ToLower().Contains(id.ToLower())
                    select p).ToList();
        }

        //Metodo por id
        public Deportista ConsultarPorId(string id)        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT Persona.id,Persona.tipoIdentificacion,Persona.nombre,Persona.apellido,Persona.sexo,Persona.fecha_Nacimiento,Persona.telefono,Persona.email,Deportista.peso,Deportista.altura,Deportista.deporte,Deportista.pesoActual,Deportista.fechaEgreso,Deportista.caloriasDiarias,Deportista.metabolismoBasal,Deportista.termogenesisActividadFisica FROM Persona FULL OUTER JOIN Deportista ON Persona.id = Deportista.id WHERE role=0 AND Persona.id = @id";
                command.Parameters.Add(new SqlParameter("@id",id));
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Deportista deportista = new Deportista();
                    deportista.id = dataReader.GetString(0);
                    deportista.TipoId = dataReader.GetString(1);
                    deportista.Nombre = dataReader.GetString(2);
                    deportista.Apellidó = dataReader.GetString(3);
                    deportista.Sexo = dataReader.GetString(4);
                    deportista.Fecha_Nacimiento = dataReader.GetDateTime(5);//Agregada ultimo momentos
                    deportista.Telefono = dataReader.GetString(6);
                    deportista.Correo = dataReader.GetString(7);
                    deportista.Peso = dataReader.GetDouble(8);
                    deportista.Altura = dataReader.GetDouble(9);
                    deportista.Deporte = dataReader.GetString(10);
                    deportista.FechaEgreso = dataReader.GetDateTime(12);
                    deportista.CaloriasDiarias = dataReader.GetDouble(13);
                    deportista.MetabolismoBasal = dataReader.GetDouble(14);
                    deportista.TermogenesisActividadFisica = dataReader.GetString(15);
                    return deportista;
                }
                dataReader.Close();
            }
            return null;
        }


        //Metodo de Modificar Persona
        public void EditarPerson(Deportista persona,string id)
        {
            using (var commands = connection.connectionDB.CreateCommand())
            {
                commands.CommandText = @"UPDATE Persona SET id = @id, tipoIdentificacion = @tipoIdentificacion, nombre = @nombre , apellido = @apellido , 
                                         sexo = @sexo, fecha_Nacimiento = @fecha_Nacimiento, telefono = @telefono, email = @email 
                                        WHERE id = @id";
                commands.Parameters.Add(new SqlParameter("@id", persona.id));
                commands.Parameters.Add(new SqlParameter("@tipoIdentificacion", persona.TipoId));
                commands.Parameters.Add(new SqlParameter("@nombre", persona.Nombre));
                commands.Parameters.Add(new SqlParameter("@apellido", persona.Apellidó));
                commands.Parameters.Add(new SqlParameter("@sexo", persona.Sexo));
                commands.Parameters.Add(new SqlParameter("@fecha_Nacimiento", persona.Fecha_Nacimiento));
                commands.Parameters.Add(new SqlParameter("@telefono", persona.Telefono));
                commands.Parameters.Add(new SqlParameter("@email", persona.Correo));
                commands.Parameters.Add(new SqlParameter("@peso", persona.Peso));
                commands.Parameters.Add(new SqlParameter("@Altura", persona.Altura));
                commands.Parameters.Add(new SqlParameter("@Deporte", persona.Deporte));
                commands.Parameters.Add(new SqlParameter("@TipoEntrenamiento", persona.TermogenesisActividadFisica));
                commands.ExecuteNonQuery();
            }
        }

        //Metodo de Consultar Dieta
        public Dieta ConsultaDieta(string id)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"Select *from Persona WHERE idDeportista=@id";
                command.Parameters.Add(new SqlParameter("@id", id));
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Dieta dieta = new Dieta();
                    dieta.IdDieta = dataReader.GetString(0);
                    dieta.DiasAplicados = dataReader.GetString(1);
                    dieta.DiasAplicados = dataReader.GetString(2);
                    dieta.RecomendacionNutriccional = dataReader.GetString(3);
                    dieta.identificacion = dataReader.GetString(4);
                    dieta.plantillas = dataReader.GetString(5);

                    return dieta;
                }
                dataReader.Close();
            }
            return null;
        }

    }


}
