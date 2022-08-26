
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace CarStoreApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(config.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("CarStoreApi"));
            return new RepositoryContext(builder.Options);
        }
    }
    
    
}
