using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WindowsFormsApp1.Models
{
    public class DataUsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataUsersContext(DbContextOptions<DataUsersContext> options) : base(options) { }

        public DataUsersContext() { }

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
