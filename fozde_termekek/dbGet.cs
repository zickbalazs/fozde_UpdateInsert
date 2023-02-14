using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace fozde_termekek
{
    class dbGet
    {
        public static List<Termek> Termekek()
        {
            List<Termek> termekek = new List<Termek>();
            MySqlConnection connection = new MySqlConnection(Data.dbConnection);
            try
            {
                connection.Open();
                MySqlDataReader reader = Data.ReaderBuilder(connection, "select * from termekek");
                while (reader.Read())
                {
                    termekek.Add(new Termek(Convert.ToInt32(reader["ID"]), reader["nev"].ToString(), Convert.ToInt32(reader["evjarat"]), Convert.ToDouble(reader["erosseg"]), Convert.ToInt32(reader["literar"])));
                }
                connection.Close();
            }
            catch (Exception)
            {
            }
            return termekek;
        }
        public static List<Kiszereles> Kiszerelesek()
        {
            List<Kiszereles> kiszerelesek = new List<Kiszereles>();
            MySqlConnection connection = new MySqlConnection(Data.dbConnection);
            try
            {
                connection.Open();
                MySqlDataReader reader = Data.ReaderBuilder(connection, "select * from mertekegysegek");
                while (reader.Read())
                {
                    kiszerelesek.Add(new Kiszereles(Convert.ToInt32(reader["ID"]), reader["egysegnev"].ToString(), Convert.ToDouble(reader["mennyiseg"])));
                }
                connection.Close();
            }
            catch (Exception)
            {
            }
            return kiszerelesek;
        }
        public static List<TermekKiszereles> TermekKiszerelesek()
        {
            List<TermekKiszereles> termekKiszereles = new List<TermekKiszereles>();

            MySqlConnection connection = new MySqlConnection(Data.dbConnection);
            try
            {
                connection.Open();
                MySqlDataReader reader = Data.ReaderBuilder(connection, "select * from termekegysegek");
                while (reader.Read())
                {
                    termekKiszereles.Add(new TermekKiszereles(Convert.ToInt32(reader["ID"]), Convert.ToInt32(reader["termekID"]), Convert.ToInt32(reader["mertekID"])));
                }
                connection.Close();
            }
            catch (Exception)
            {
            }

            return termekKiszereles;
        }
    }
}
