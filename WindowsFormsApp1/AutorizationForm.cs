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
        private DataContext db = new DataContext();
        int us;
        
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
                labelWarningLogPaswd.Visible = true;
            }
            else
            {
                this.Hide();
                GlobalForm globalform = new GlobalForm();
                globalform.Show();
                us = account.UserId;
                globalform.LoginTXT(account.UserName, account.UserRight, account.UserId);
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
