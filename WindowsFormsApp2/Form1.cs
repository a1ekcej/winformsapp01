using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String paswdUser = textBox2.Text;


            MySqlDBclass db = new MySqlDBclass();

            try
            {
                db.OpenConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
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
