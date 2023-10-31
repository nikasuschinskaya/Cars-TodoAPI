using Cars.WebAPI.Entities;
using Cars.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Cars.WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarEntity> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies();
    }
}
