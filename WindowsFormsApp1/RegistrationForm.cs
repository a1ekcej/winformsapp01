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

            if (textBoxConfirmPaswd.Text != textBoxPaswd.Text)
            {
                labelEquealPAswd.Visible = true;
            }
            // Присваиваем данные модели User
            User user = new User()
            {
                UserName = textBoxLogin.Text,
                UserPassword = BCrypt.Net.BCrypt.HashString(textBoxPaswd.Text),
                UserRight = "user"
            };
            // Вносим данные в БД и сохраняем БД
            db.Users.Add(user);
            db.SaveChanges();
            // Очистка формы
            foreach (Control c in base.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalForm global = new GlobalForm();
            global.Show();
        }

        private void CleanForm()
        {
            textBoxLogin.Text = "";
            textBoxPaswd.Text = "";
            textBoxConfirmPaswd.Text = "";
            checkBoxPaswd.Checked = false;
            textBoxEmail.Text = "";
        }
    }
}
