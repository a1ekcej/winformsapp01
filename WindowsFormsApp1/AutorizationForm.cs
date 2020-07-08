using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        public string TextInfo
        {
            get { return loginfield.Text; }
            set { loginfield.Text = value; }

        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }

        private void signInbtn_Click(object sender, EventArgs e)
        {
            
            String loginUser = loginfield.Text;
            String paswdUser = paswdfield.Text;

            TextInfo = loginUser;
            DBUsers db = new DBUsers();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `paswd` = @up", db.GetConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = paswdUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                GlobalForm global = new GlobalForm();
                global.LoginTXT = loginUser;
               
                global.Show();
            }
            else 
                MessageBox.Show("NO!");
        }
    }
}
