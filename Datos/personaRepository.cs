using Entidad;
using Entidad.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class personaRepository
    {
        public readonly ConnectionDB ConnectionDB = new ConnectionDB();

        //Metodo Login
        public bool Login(string email,string password)
        {
            using (var commands = ConnectionDB.connectionDB.CreateCommand()) 
            {
                commands.CommandText = @"SELECT * FROM Persona WHERE email=@email AND Password=@pass";
                commands.Parameters.Add(new SqlParameter("@email",email));
                commands.Parameters.Add(new SqlParameter("@pass", password));
                commands.CommandType = CommandType.Text;
                SqlDataReader reader = commands.ExecuteReader();
                Persona persona = new Persona();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.Id = reader.GetString(0);
                        UserLoginCache.FirstName = reader.GetString(2);
                        UserLoginCache.LastName = reader.GetString(3);
                        UserLoginCache.Sexo = reader.GetString(4);
                        UserLoginCache.Fecha_Nacimineto = reader.GetDateTime(5);
                        UserLoginCache.Email = reader.GetString(7);
                        UserLoginCache.Rol = reader.GetInt32(9);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Metodo de consultar
        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            using (var command = ConnectionDB.connectionDB.CreateCommand())
            {
                command.CommandText = "select *from Persona";
                var dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = dataReader.GetString(0);
                    persona.TipoId = dataReader.GetString(1);


                    personas.Add(persona);
                }
                dataReader.Close();
            }
            return personas;
        }
    }
}
