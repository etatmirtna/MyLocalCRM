using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace DataService.Repositories;

public class SqlConnectionFactory : IDbConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public DbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
