using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiszereles_torlo
{
    public partial class Form1 : Form
    {
        static List<Termek> products = DB.Get.Products();
        static List<TermekKiszereles> productsizing = DB.Get.ProductSizings();
        static List<Kiszereles> sizings = DB.Get.Sizings();
        public Form1()
        {
            InitializeComponent();
            SetItems();
        }
        private void SetItems()
        {
            comboBox1.Items.AddRange(sizings.Select(e => e.unitName).ToArray());
            comboBox1.SelectedIndexChanged += delegate { ComboboxChange(); };
            button1.Click += delegate { Delete(); };
            listBox1.SelectedIndexChanged += delegate { FillMod(); };
        }
        private void FillMod()
        {
            productsizingbox.Items.Clear();
            productsizingbox.Items.AddRange(sizings.Select(e=>e.unitName).ToArray());
        }
        private void ComboboxChange()
        {
            listBox1.Items.Clear();
            products.ForEach(e =>
            {
               productsizing.ForEach(t =>
               {
                   if (e.ID == t.productID && sizings[comboBox1.SelectedIndex].ID == t.sizingID) listBox1.Items.Add(e.ID + "-" + e.Name);
               });
            });
            if (listBox1.Items.Count > 1)
            {
                listBox1.Visible = true;
                label1.Visible = true;
                button1.Enabled = false;
            }
            else
            {
                listBox1.Visible = false;
                label1.Visible = false;
                button1.Enabled = true;
            }
        }
        private void Delete()
        {
            int id = comboBox1.SelectedIndex;
            if (DB.Delete.Sizing(sizings[comboBox1.SelectedIndex].ID))
            {
                MessageBox.Show("Sikeres törlés");
                sizings.Remove(sizings[id]);
                comboBox1.SelectedIndex = 0;
                comboBox1.Items.Remove(comboBox1.Items[id]);
            }
            else
            {
                MessageBox.Show("Sikertelen törlés");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DB.Modify.ProductSizing(sizings[productsizingbox.SelectedIndex].ID, Convert.ToInt32(listBox1.SelectedItem.ToString().Split('-')[0].ToString()), sizings[comboBox1.SelectedIndex].ID))
            {
                MessageBox.Show("Sikeres módosítás!");
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = 0;
            }
            else
            {

                MessageBox.Show("Sikertelen módosítás!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DB.Delete.ProductSizing(Convert.ToInt32(listBox1.SelectedItem.ToString().Split('-')[0]), sizings[comboBox1.SelectedIndex].ID))
            {
                MessageBox.Show("Sikeres törlés!");
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Sikertelen törlés!");
            }
        }
    }
}
