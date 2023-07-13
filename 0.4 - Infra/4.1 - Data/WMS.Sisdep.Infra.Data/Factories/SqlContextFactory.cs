using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WMS.Sisdep.Infra.Data.Contexts;

namespace WMS.Sisdep.Infra.Data.Factories
{
    public class SqlContextFactory : IDesignTimeDbContextFactory<SqlContextMigration>
    {
        public SqlContextMigration CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("LOCAL") ?? string.Empty;

            var optionsBuilder = new DbContextOptionsBuilder<SqlContextMigration>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SqlContextMigration(optionsBuilder.Options);
        }
    }
}
