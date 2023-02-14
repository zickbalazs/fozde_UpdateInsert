using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace fozde_termekek
{
    class dbUpdate
    {
        public static void Termekek(Termek modTermek, TermekKiszereles ksz, Kiszereles k)
        {
            MySqlConnection connection = new MySqlConnection(Data.dbConnection);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"update termekek set nev='{modTermek.nev}', evjarat='{modTermek.evjarat}', erosseg='{modTermek.erosseg}', literar='{modTermek.literAr}' where ID={modTermek.ID}; update termekegysegek set termekID='{modTermek.ID}', mertekID='{k.ID}' where ID={ksz.ID}", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                System.Windows.Forms.MessageBox.Show("Sikeres módosítás");
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
