public class DbConnection
{
    private string _connectionstring;
    private TimeSpan _timeout;

    public string ConnectionString
    {
        get { return _connectionstring; }
        set { _connectionstring = value; }
    }

public DbConnection(string connectionstring)  
{
    _connectionstring = connectionstring;
    if(!string.IsNullOrEmpty(ConnectionString))
    throw new ArgumentException(ConnectionString);
    
}
    public void Open()
    {

    }
    public void Close()
    {

    }
}