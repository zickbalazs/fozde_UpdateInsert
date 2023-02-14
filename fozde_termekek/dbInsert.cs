using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace fozde_termekek
{
    class dbInsert
    {
        public static void toTermekek(Termek newTermek, Kiszereles selectedKiszereles)
        {
            MySqlConnection connection = new MySqlConnection(Data.dbConnection);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"insert into termekek (id, nev, evjarat, erosseg, literar) values ('{newTermek.ID}',  '{newTermek.nev}', '{newTermek.evjarat}', '{newTermek.erosseg}', '{newTermek.literAr}'); insert into termekegysegek (termekID, mertekID) values ('{newTermek.ID}','{selectedKiszereles.ID}');", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sikeres feltöltés!");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
