using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Rendeles
{
    class DatabaseIO
    {
        private static string path = "server=localhost;database=fozde;uid=root; pwd=;";
        public static List<Classes.Product> GetProducts()
        {
            List<Classes.Product> Products = new List<Classes.Product>();
            try
            {
                MySqlConnection sql = new MySqlConnection(path);
                sql.Open();
                MySqlCommand cmd = new MySqlCommand("select * from termekek", sql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products.Add(new Classes.Product(Convert.ToInt32(reader["ID"]), reader["nev"].ToString(), Convert.ToInt32(reader["evjarat"]), Convert.ToDouble(reader["erosseg"]), Convert.ToDouble(reader["literar"])));
                }
                sql.Close();
            }
            catch (MySqlException)
            {

            }
            return Products;
        }
        public static List<Classes.Sizing> GetSizings()
        {
            List<Classes.Sizing> Sizings = new List<Classes.Sizing>();
            try
            {
                MySqlConnection sql = new MySqlConnection(path);
                sql.Open();
                MySqlCommand cmd = new MySqlCommand("select * from mertekegysegek", sql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sizings.Add(new Classes.Sizing(Convert.ToInt32(reader["ID"]), reader["egysegnev"].ToString(), Convert.ToDouble(reader["mennyiseg"])));
                }
                sql.Close();
            }
            catch (MySqlException)
            {

            }
            return Sizings;
        }
        public static List<Classes.SizingProduct> GetConnections()
        {
            List<Classes.SizingProduct> connnections = new List<Classes.SizingProduct>();
            try
            {
                MySqlConnection sql = new MySqlConnection(path);
                sql.Open();
                MySqlCommand cmd = new MySqlCommand("select * from termekegysegek", sql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    connnections.Add(new Classes.SizingProduct(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["mertekID"]), Convert.ToInt32(reader["termekID"])));
                }
                sql.Close();
            }
            catch (MySqlException)
            {

            }
            return connnections;
        }
    }
}
