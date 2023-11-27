using System.Data;
using AspNetCore.Identity.Dapper;
using Microsoft.Data.Sqlite;

namespace Microsoft.Extensions.DependencyInjection
{
    internal class SqliteDbConnectionFactory : IDbConnectionFactory
    {
        public string ConnectionString { get; set; }

        public IDbConnection Create() {
            var dbConnection = new SqliteConnection(ConnectionString);
            dbConnection.Open();
            return dbConnection;
        }
    }
}