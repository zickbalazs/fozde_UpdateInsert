using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace kiszereles_torlo.DB
{
    class Get
    {
        public static List<Termek> Products()
        {
            List<Termek> products = new List<Termek>();
            try
            {
                Stores.connection.Open();
                MySqlCommand command = cmd("termekek");
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Termek(Convert.ToInt32(reader["ID"]), reader["nev"].ToString(), Convert.ToInt32(reader["evjarat"]), Convert.ToDouble(reader["erosseg"]), Convert.ToDouble(reader["literar"])));
                }
                Stores.connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return products;
        }
        public static List<TermekKiszereles> ProductSizings()
        {
            List<TermekKiszereles> productsizings = new List<TermekKiszereles>();
            try
            {
                Stores.connection.Open();
                MySqlCommand command = cmd("termekegysegek");
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productsizings.Add(new TermekKiszereles(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["termekID"]), Convert.ToInt32(reader["mertekID"])));
                }
                Stores.connection.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return productsizings;
        }
        public static List<Kiszereles> Sizings()
        {
            List<Kiszereles> sizings = new List<Kiszereles>();
            try
            {
                Stores.connection.Open();
                MySqlCommand command = cmd("mertekegysegek");
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sizings.Add(new Kiszereles(Convert.ToInt32(reader["id"]), reader["egysegnev"].ToString(), Convert.ToDouble(reader["mennyiseg"])));
                }
                Stores.connection.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return sizings;
        }
        private static MySqlCommand cmd(string command)
        {
            return new MySqlCommand($"select * from {command}", Stores.connection);
        }
    }
}
