
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserRight { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        public User()
        {
            Tenants = new List<Tenant>();
        }
        public ICollection<ArendaObject> ArendaObjects { get; set; }
        public User(List<ArendaObject> a)
        {
            this.ArendaObjects = new List<ArendaObject>();

        }
    }
}
