using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace kiszereles_torlo.DB
{
    class Delete
    {
        public static bool Sizing(int id)
        {
            try
            {
                Stores.connection.Open();
                MySqlCommand command = cmd("mertekegysegek", $"ID={id}");
                command.ExecuteNonQuery();
                Stores.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        public static bool ProductSizing(int productID, int sizingID)
        {
            try
            {
                Stores.connection.Open();
                MySqlCommand command = cmd("termekegysegek", $"termekID={productID} and mertekID={sizingID}");
                command.ExecuteNonQuery();
                Stores.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }
        private static MySqlCommand cmd(string table, string parameters)
        {
            return new MySqlCommand($"delete from {table} where {parameters}", Stores.connection);
        }
    }
}
