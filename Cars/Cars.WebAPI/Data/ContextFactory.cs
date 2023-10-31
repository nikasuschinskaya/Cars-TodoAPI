using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cars.WebAPI.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBulder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBulder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));

            return new ApplicationDbContext(optionsBulder.Options);
        }
    }
}
