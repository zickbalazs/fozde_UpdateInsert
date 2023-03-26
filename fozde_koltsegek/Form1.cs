using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_koltsegek
{
    public partial class Form1 : Form
    {
        static List<Sizing> sizings = DB.GetSizings();
        public Form1()
        {
            InitializeComponent();
            fillCombobox();
        }

        private void fillCombobox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Új hozzáadása");
            comboBox1.SelectedIndex = 0;
            comboBox1.Items.AddRange(sizings.Select(e => $"{e.ID};{e.Name}").ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                Sizing selectedSizing = sizings.Find(g => g.ID == Convert.ToInt32(comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';')[0]));
                if (DB.UpdateSizing(nameTbx.Text, Convert.ToDouble(amountTbx.Text), selectedSizing.ID))
                {
                    MessageBox.Show("Sikeres módosítás!");
                    sizings = DB.GetSizings();
                    fillCombobox();
                }
                else MessageBox.Show("Sikertelen módosítás!");
            }
            else
            {
                if (DB.UploadSizing(Convert.ToDouble(amountTbx.Text), nameTbx.Text)){
                    MessageBox.Show("Sikeres feltöltés!");
                    sizings = DB.GetSizings();
                    fillCombobox();
                }
                else
                {
                    MessageBox.Show("Sikertelen feltöltés!");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > 0)
            {
                Sizing selectedSizing = sizings.Find(g => g.ID == Convert.ToInt32(comboBox1.Items[comboBox1.SelectedIndex].ToString().Split(';')[0]));
                button1.Text = "Kiszerelés módosítása";
                nameTbx.Text =  selectedSizing.Name;
                amountTbx.Text = selectedSizing.Size.ToString();
            }
            else
            {
                nameTbx.Text = "";
                amountTbx.Text = "";
                button1.Text = "Kiszerelés hozzáadása";
            }
        }
    }
}
