var oracle = new OracleConnection("oracle-server");
var sql = new SqlConnection("Sql-server");
var command = new DbCommand(oracle, "run");
command.Exectue();