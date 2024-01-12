public class SqlConnection: DbConnection

{
    public SqlConnection(string connectionstring) : base(connectionstring)
    {
    }

    public override void Open()
    {
        System.Console.WriteLine("Opening SQL server");
    }
    public override void Close()
    {
        System.Console.WriteLine("Closing SQL server");
    }
}
