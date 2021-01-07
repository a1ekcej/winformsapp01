using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Models
{
    public class DataUsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataUsersContext(DbContextOptions<DataUsersContext> options) : base(options) { }

        public DataUsersContext()
        {
            
            Database.EnsureCreated();
        }
    }
}
