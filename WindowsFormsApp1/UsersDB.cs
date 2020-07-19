using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class UsersDB: DbContext
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone_1 { get; set; }
        public string Address { get; set; }
        public string Phone_2 { get; set; }
        public string Passport { get; set; }

    }
}
