using Npgsql;

var connString = "Host=localhost;Port=5432;Database=DBBackend;Username=postgres;Password=12345";

try
{
    using var conn = new NpgsqlConnection(connString);
    conn.Open();
    Console.WriteLine("Conexión exitosa a PostgreSQL.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error al conectar: {ex.Message}");
}