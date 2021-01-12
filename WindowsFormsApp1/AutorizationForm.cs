using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class AutorizationForm : Form
    {
        private DataUsersContext db = new DataUsersContext(); 
        
        public AutorizationForm()
        {
            InitializeComponent();
        }
// Вызов формы регистрации
        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }

        // Вызов формы авторизации
        private void signInbtn_Click(object sender, EventArgs e)
        {
            var account = loginUser(loginfield.Text, paswdfield.Text);
            if (account == null)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                this.Hide();
                GlobalForm global = new GlobalForm();
                global.Show();
            }
        }

        public User loginUser (string loginUser, string paswdUser)
        {
            var account = db.Users.SingleOrDefault(a => a.UserName.Equals(loginUser));
            if (account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(paswdUser, account.UserPassword))
                {
                    return account;
                }
            }
            return null;
        }
           

    
    }
}
