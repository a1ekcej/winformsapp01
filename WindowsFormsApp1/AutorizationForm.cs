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

            
            DBUsers db = new DBUsers();

            try
            {
                db.OpenConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
          
            } finally
            {
                db.CloseConnection();
            }

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @luser AND `paswd` = @puser", db.GetConnection());

            command.Parameters.Add("@luser", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@puser", MySqlDbType.VarChar).Value = paswdUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes!");
                //this.Hide();
                //GlobalForm global = new GlobalForm();
                //global.Show();
            }
            else 
                MessageBox.Show("NO!");
        }
    }
}
