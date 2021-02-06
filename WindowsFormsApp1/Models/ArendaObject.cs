using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Models
{
    public class ArendaObject
    {
        public int ArendaObjectId { get; set; }
        public string ObjectName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int? ApartmentNumber { get; set; }
        public double? HouseArea { get; set; }
        public int? NumberRoom { get; set; }
        public int? Floor { get; set; }
        public string Owner { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
       

    }
}