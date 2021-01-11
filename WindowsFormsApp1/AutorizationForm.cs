using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

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
            SqlConnection connection = new SqlConnection();
            SqlDataAdapter adapter = default(SqlDataAdapter);
            DataTable table = new DataTable();

            //try
            //{
            //    using (DataUsersContext data = new DataUsersContext())
            //    {
                  
            //    }
                
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("Error: " + ex.Message,
            //                                            "SQLServer Connnection Failed",

            //                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    table = null;
            //}

            DataUsersContext db = new DataUsersContext();
            
           
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserName = @ul AND UserPassword = @up");

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
