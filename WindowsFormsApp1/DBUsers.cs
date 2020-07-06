using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class DBUsers
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=mydb");

        public void OpenConnection () 
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    connection.Open();
                    Console.WriteLine("Подключение открыто");
                }
                finally
                {
                    connection.Close();
                }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
