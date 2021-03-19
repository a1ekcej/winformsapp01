using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WindowsFormsApp1.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<ArendaObject> ArendaObjects { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var buider = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = buider.Build();
            optionsBuilder.UseSqlServer(config["ConnectionStrings:DefaultConnection"]);
        }
    }
}
