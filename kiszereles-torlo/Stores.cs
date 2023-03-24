using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kiszereles_torlo
{
    class Stores
    {
        private static string connectionString = new MySqlConnectionStringBuilder()
        {
            Database = "fozde",
            Server = "localhost",
            UserID = "root",
            Password = ""
        }.ToString();
        public static MySqlConnection connection = new MySqlConnection(connectionString);

    }
}
