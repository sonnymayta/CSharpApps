using Npgsql;

namespace ConnectionDataBase
{
    public class TestConnectionPostgres
    {
        public static void TestConnection()
        {
            string connectionString = "Host=localhost;Port=5432;Database=DBExample;Username=postgres;Password=DBadmin";
            try
            {
                using var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión exitosa a PostgreSQL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
            }
        }
    }
}
