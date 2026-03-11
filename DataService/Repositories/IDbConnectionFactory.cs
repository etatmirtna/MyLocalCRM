using System.Data.Common;

namespace DataService.Repositories;

public interface IDbConnectionFactory
{
    DbConnection CreateConnection();
}
