using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace fozde_koltsegek
{
    internal class DB
    {
        public static List<Sizing> GetSizings()
        {
            List<Sizing> sizings = new List<Sizing>();
            try
            {
                MySqlConnection connection = new MySqlConnection(new MySqlConnectionStringBuilder() { Database = "fozde", UserID="root", Password="", Server="localhost" }.ToString()); 
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * from mertekegysegek", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sizings.Add(new Sizing(Convert.ToInt32(reader["ID"]), reader["egysegnev"].ToString(), Convert.ToDouble(reader["mennyiseg"])));
                }
                connection.Close();
            }
            catch (MySqlException){}
            return sizings;
        }
        public static bool UploadSizing(double size, string name)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new MySqlConnectionStringBuilder() { Database = "fozde", UserID = "root", Password = "", Server = "localhost" }.ToString());
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into mertekegysegek (egysegnev, mennyiseg) values ('{name}', {size.ToString().Replace(',', '.')})", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (MySqlException) { return false; }
        }
        public static bool UpdateSizing(string name, double size, int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(new MySqlConnectionStringBuilder() { Database = "fozde", UserID = "root", Password = "", Server = "localhost" }.ToString());
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"update mertekegysegek set mennyiseg='{size.ToString().Replace(',', '.')}', egysegnev='{name}' where ID={id}", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
                return true;
            }
            catch (MySqlException) { return false; }
        }
    }
}
