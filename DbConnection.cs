public abstract class DbConnection
{
    private string _connectionstring;
   // private TimeSpan _timeout;

    private string ConnectionString
    {
        get { return _connectionstring; }
        set { _connectionstring = value; }
    }

public DbConnection(string connectionstring)  
{
    _connectionstring = connectionstring;
    if(string.IsNullOrWhiteSpace(ConnectionString))
    throw new ArgumentException("Value cant be null or empty");
    
}
    public abstract void Open();
    
    public abstract void Close();
}