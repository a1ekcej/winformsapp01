﻿namespace WindowsFormsApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        private string UserPassword { get; set; }
        public string UserRight { get; set; }
    }
}
