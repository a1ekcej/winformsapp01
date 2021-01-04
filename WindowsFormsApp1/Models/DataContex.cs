  using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Models
{
    public class DataContex: DbContext
    {
        public DataContex() : base() { }
        public DbSet<Tenant> Tenants { get; set; }


    }
}
