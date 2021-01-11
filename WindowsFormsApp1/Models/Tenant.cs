using System;

namespace WindowsFormsApp1.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ThirdName { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Email { get; set; }
        public DateTime Lease_date { get; set; }
        public decimal Rent_price { get; set; }
        public decimal Pledge { get; set; }
        public int Series_passport { get; set; }
        public int Number_passport { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
