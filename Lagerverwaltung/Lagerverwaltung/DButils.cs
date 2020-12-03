
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Lagerverwaltung
{
    class DButils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "lagerjournal";
            string username = "root";
            string password = "";

            return DBMySQLUtlis.GetDBConnection(host, port, database, username, password);
        }
    }
}