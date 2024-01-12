public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionstring) : base(connectionstring)
    {
    }

    public override void Open()
    {
        System.Console.WriteLine("Opening Oracle server");
    }
    public override void Close()
    {
        System.Console.WriteLine("Closing Oracle server");
    }
}