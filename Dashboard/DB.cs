using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Dashboard
{
    class DB
    {
        public static bool Login(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(new MySqlConnectionStringBuilder()
            {
                Database = "fozde",
                UserID = "root",
                Password = "",
                Server = "localhost"
            }.ToString());
            MySqlCommand cmd = new MySqlCommand("select * from bejelentkezes", conn);
            try
            {
                conn.Open();
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    if (data["nev"].ToString()==username && data["jelszo"].ToString() == password)
                    {
                        conn.Close();
                        return true;
                    }
                }
                conn.Close();
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            MySqlConnection conn = new MySqlConnection(new MySqlConnectionStringBuilder()
            {
                Database = "fozde",
                UserID = "root",
                Password = "",
                Server = "localhost"
            }.ToString());
            MySqlCommand cmd = new MySqlCommand("select * from bejelentkezes", conn);
            try
            {
                conn.Open();
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    users.Add(new User(Convert.ToInt32(data["id"]),
                                    data["nev"].ToString(),
                                    data["jelszo"].ToString(),
                                    Convert.ToInt32(data["jogosultsag"])
                    ));
                }
                conn.Close();
            }
            catch (MySqlException)
            {}
            return users;
        }
        public static User GetUser(string username = "", string password = "", int id = -1)
        {
            MySqlConnection conn = new MySqlConnection(new MySqlConnectionStringBuilder()
            {
                Database = "fozde",
                UserID = "root",
                Password = "",
                Server = "localhost"
            }.ToString());
            
            string mysqlcmd = "";
            if (id != -1)
            {
                mysqlcmd = $"select * from bejelentkezes where id={id}";
            }
            else if (username != "")
            {
                mysqlcmd = $"select * from bejelentkezes where jelszo='{password}' and nev='{username}'";
            }
            MySqlCommand cmd = new MySqlCommand(mysqlcmd, conn);
            try
            {
                conn.Open();
                MySqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    return new User(Convert.ToInt32(data["id"]),
                                    data["nev"].ToString(), 
                                    data["jelszo"].ToString(),
                                    Convert.ToInt32(data["jogosultsag"])
                    );
                }
                conn.Close();
                return new User(0,"","",2);
            }
            catch (MySqlException)
            {
                return new User(0,"","",2);
            }
        }
    }
}
