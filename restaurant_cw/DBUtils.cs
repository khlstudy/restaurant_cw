using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace restaurant_cw
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()

        {
            string host = "localhost";
            int port = 3306;
            string database = "restaurant";
            string username = "monty";
            string password = "some_pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}

