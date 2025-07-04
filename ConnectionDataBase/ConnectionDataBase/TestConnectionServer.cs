using Microsoft.Data.SqlClient;

namespace ConnectionDataBase
{
    class TestConnectionServer
    {
        public static void TestConnection()
        {
            string connectionString = "Server=PC-SONNY;Database=DBExample;Trusted_Connection=True;Trust Server Certificate=True";
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión exitosa a SQL Server.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
            }
        }
    }
}
