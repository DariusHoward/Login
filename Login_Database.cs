using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login
{
    class Login_Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=login_users");

        ///function opens connection 
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
