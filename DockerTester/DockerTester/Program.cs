using IBM.Data.Db2;

try
{
    string? connectionString = Environment.GetEnvironmentVariable("ConnectionString");
    
    if (string.IsNullOrEmpty(connectionString))
    {
        Console.WriteLine("Error: ConnectionString environment variable is not set.");
        return;
    }

    using (DB2Connection connection = new DB2Connection(connectionString))
    {
        connection.Open();
        Console.WriteLine("Connection opened successfully!");
        Console.WriteLine($"Server Type: {connection.ServerType}");
        Console.WriteLine($"Database: {connection.Database}");
        Console.WriteLine($"Connection State: {connection.State}");
    }
}
catch (DB2Exception ex)
{
    Console.WriteLine($"DB2 Error: {ex.Message}");
    Console.WriteLine($"Error Code: {ex.ErrorCode}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
