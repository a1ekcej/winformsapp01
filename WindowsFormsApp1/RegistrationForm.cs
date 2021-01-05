using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        { 

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Путь к текущей БД
            // Создание конфигурации подключения
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appconfig.json;");
            var config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DataContex>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (DataContex db = new DataContex(options))
            {
                
            }
        }
    }
}
