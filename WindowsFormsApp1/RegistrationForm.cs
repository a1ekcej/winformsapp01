using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{

    public partial class RegistrationForm : Form
    {
        DataUsersContext usr = new DataUsersContext(); 
        
        string role;
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
            DataUsersContext db = new DataUsersContext();
            // Проверка на роль админа
            if (rbAdmin != null)
            {
                gbmasterPased.Visible = true;
                AutorizationForm f1 = new AutorizationForm();
                var acc = f1.loginUser(textBoxAdminLog.Text, textBoxAdminPaswd.Text);
                if (acc != null)
                {
                    role = "admin";
                } else
                {
                    MessageBox.Show("Login or Password is Failed!!!");
                }
            } else role = "user";
            // Присваиваем данные модели User
            User user = new User()
            {
                UserName = textBoxLogin.Text,
                UserPassword = BCrypt.Net.BCrypt.HashString(textBoxPaswd.Text),
                UserRight = role
            };
            // Вносим данные в БД и сохраняем БД
            db.Users.Add(user);
            db.SaveChanges();
            // Очистка формы
            foreach (Control c in base.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                rbAdmin = null;
                gbmasterPased.Visible = false;
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm global = new GlobalForm();
            global.Show();
        }
    }
}
