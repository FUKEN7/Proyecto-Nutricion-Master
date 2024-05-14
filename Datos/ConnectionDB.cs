using System;
using System.Data.SqlClient;

namespace Datos
{
    public class ConnectionDB
    {
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Nutrisoft;Trusted_Connection=True;";
        public SqlConnection connectionDB = new SqlConnection();

        public ConnectionDB()
        {
            connectionDB.ConnectionString = connectionString;
        }

        public void Open()
        {
            try
            {
                connectionDB.Open();
                Console.WriteLine("---Connection DataBase---");
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR" + e.Message);
            }
        }

        public void Close()
        {
            connectionDB.Close();
        }

    }
}
