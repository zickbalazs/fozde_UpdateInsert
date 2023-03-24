using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace kiszereles_torlo.DB
{
    class Modify
    {
        public static bool ProductSizing(int newsizingID, int productID, int sizingID)
        {
            try
            {
                Stores.connection.Open();
                cmd("termekegysegek", $"mertekID={newsizingID}", $"termekID={productID} and mertekID={sizingID}").ExecuteNonQuery();
                Stores.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        private static MySqlCommand cmd(string table, string updateText ,string parameters)
        {
            return new MySqlCommand($"update {table} set {updateText} where {parameters}", Stores.connection);
        }
    }
}
