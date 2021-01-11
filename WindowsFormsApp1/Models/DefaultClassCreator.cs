using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WindowsFormsApp1.Models

{
    public class DefaultClassCreator : IDesignTimeDbContextFactory<DataUsersContext>
    {
        public DataUsersContext CreateDbContext(string[] args)
        {
            // Путь к текущей БД
            // Создание конфигурации подключения
            var optionsBuilder = new DbContextOptionsBuilder<DataUsersContext>();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            
            optionsBuilder.UseSqlServer(connectionString);
            return new DataUsersContext(optionsBuilder.Options);
        }
    }
}
