using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1.Models
{
    public class DataUsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataUsersContext(DbContextOptions<DataUsersContext> options) : base(options) { }

        public DataUsersContext() { }
    }
}
