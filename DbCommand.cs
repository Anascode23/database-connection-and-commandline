public class DbCommand
{
    private readonly DbConnection _connection;
    private readonly string _intrution;

    
    public DbCommand(DbConnection connection, string intrution)
    {
        _connection = connection;
        if (_connection == null)
            throw new ArgumentException("Value cant be null");
        _intrution = intrution;
        if (string.IsNullOrWhiteSpace(_intrution))
            throw new ArgumentException("Value cant be null or empty");
    }

    public void Exectue()
    {
        _connection.Open();
        Console.WriteLine(_intrution);
        _connection.Close();

    }


}
