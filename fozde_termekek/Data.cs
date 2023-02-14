using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace fozde_termekek
{
    class Data
    {
        public static string dbConnection = new MySqlConnectionStringBuilder()
        {
            Database = "fozde",
            UserID = "root",
            Password = "",
            Server = "localhost"
        }.ToString();
        public static MySqlDataReader ReaderBuilder(MySqlConnection connection, string command)
        {
            MySqlCommand cmd = new MySqlCommand(command, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
