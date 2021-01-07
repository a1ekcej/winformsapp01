using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class UsersAutorisation
    {
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=DBUsers;Integrated Security=True");

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

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
