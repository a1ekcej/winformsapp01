using Microsoft.Data.SqlClient;
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
            
            String loginUser = loginfield.Text;
            String paswdUser = paswdfield.Text;
// Подключение к БД
// Выполнение запроса на авторизацию
            UsersAutorisation db = new UsersAutorisation();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `paswd` = @up", db.GetConnection());

            command.Parameters.Add("@ul", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", SqlDbType.VarChar).Value = paswdUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
// Проверка на вход в приложение
// Передача данных в фыорму авторизации
            if (table.Rows.Count > 0)
            {
                this.Hide();
                GlobalForm global = new GlobalForm();
                global.LoginTXT = loginUser;
                global.Show();
            }
            else 
                MessageBox.Show("Login incorrect. Please try again!");
        }
    }
}
