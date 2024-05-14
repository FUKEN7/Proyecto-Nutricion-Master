using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class PlantillaRepository
    {
        public readonly ConnectionDB connection = new ConnectionDB();

        public void Guardar(Plantilla plantilla)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"insert into Plantilla(nombrePlantilla)
                                                   values(@nombrePlantilla)";
                command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@nombrePlantilla", plantilla.NombrePlantilla));
                command.ExecuteNonQuery();
            }

        }
        public void GuardarPlantillaAlimento(Plantilla plantilla)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Alimento_Plantilla(idPlantilla,idAlimento,porcion,categoria)
                                        VALUES(@idPlantilla,@idAlimento,@porcion,@categoria)";
                command.Parameters.Add(new SqlParameter("@porcion", plantilla.Porcion));
                command.Parameters.Add(new SqlParameter("@categoria", plantilla.Categoria));
                command.Parameters.Add(new SqlParameter("@idPlantilla",plantilla.NombrePlantilla));
                command.Parameters.Add(new SqlParameter("@idAlimento",plantilla.idAlimento));
                command.ExecuteNonQuery();
            }
        }

        public List<Plantilla> Consultar()
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT Plantilla.nombrePlantilla,Alimento_Plantilla.porcion,Alimento_Plantilla.categoria,Alimento.nombre 
                                        FROM Alimento_Plantilla
                                        INNER JOIN Plantilla ON Alimento_Plantilla.idPlantilla=Plantilla.nombrePlantilla
                                        INNER JOIN Alimento ON Alimento_Plantilla.idAlimento=Alimento.id";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Plantilla plantilla = new Plantilla();
                    plantilla.NombrePlantilla = Reader.GetString(0);
                    plantilla.Porcion = Reader.GetInt32(1);
                    plantilla.Categoria = Reader.GetString(2);
                    plantilla.idAlimento = Reader.GetString(3);
                    plantillas.Add(plantilla);
                }
                Reader.Close();
            }
            return plantillas;
        }

        public List<Plantilla> ConsultarPlantilla()
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = @"SELECT *FROM Plantilla";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Plantilla plantilla = new Plantilla();
                    plantilla.NombrePlantilla = Reader.GetString(0);
                    plantillas.Add(plantilla);
                }
                Reader.Close();
            }
            return plantillas;
        }

        public Plantilla BuscarPorNombre(string nombre)
        {
            using (var command = connection.connectionDB.CreateCommand())
            {
                command.CommandText = "select * from Alimento where nombre=@nombre";
                command.Parameters.Add(new SqlParameter("nombre", nombre));
                var Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while(Reader.Read()){
                        Plantilla plantilla = new Plantilla();
                        plantilla.NombrePlantilla = Reader.GetString(0);
                        plantilla.Ingrediente = Reader.GetString(1);
                        plantilla.Porcion = Reader.GetInt32(2);
                        plantilla.idAlimento = Reader.GetString(3);
                        return plantilla;
                    }
                }
                Reader.Close();
            }
            return null;
        }

        public List<Plantilla> FiltarPorNombre(string nombre)
        {
            return Consultar().Where(p => p.NombrePlantilla.ToString().Contains(nombre)).ToList();
        }

    }
}
