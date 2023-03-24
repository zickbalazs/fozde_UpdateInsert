using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeles
{
    public partial class Form1 : Form
    {
        static List<Classes.Product> products = DatabaseIO.GetProducts();
        static List<Classes.Sizing> sizings = DatabaseIO.GetSizings();
        static List<Classes.SizingProduct> sizingProducts = DatabaseIO.GetConnections();
        public Form1()
        {
            InitializeComponent();
            CreateConnections();
            UpdateProducts();
            productCbx.SelectedIndex = 0;
        }
        private void CreateConnections()
        {
            foreach (Classes.Product product in products)
                product.LinqConnection(sizings, sizingProducts);
        }
        private void UpdateProducts()
        {
            foreach (Classes.Product product in products)
                productCbx.Items.Add(product.Name);
        }

        private void productCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceTbx.Text = products[productCbx.SelectedIndex].UnitPrice.ToString("# ### ") + "Ft";
            SizingCbx.Items.Clear();
            products[productCbx.SelectedIndex].Sizings.ForEach(x => SizingCbx.Items.Add(x.AmountInLitres));
            if (products[productCbx.SelectedIndex].Sizings.Count > 0)
            {
                SizingCbx.SelectedIndex = 0;
                toCartBtn.Enabled = true;
                SizingCbx.Enabled = true;
            }
            else
            {
                toCartBtn.Enabled = false;
                SizingCbx.Enabled = false;
            }
        }
        private double TotalPrice() 
            => cartLbx.Items.Cast<string>().Select(e => Convert.ToDouble(e.Split(' ')[e.Split(' ').Length - 2])).Sum();

        private void toCartBtn_Click(object sender, EventArgs e)
        {
            double price = products[productCbx.SelectedIndex].UnitPrice * products[productCbx.SelectedIndex].Sizings[SizingCbx.SelectedIndex].AmountInLitres;
            string text = products[productCbx.SelectedIndex].Name + $"({products[productCbx.SelectedIndex].Sizings[SizingCbx.SelectedIndex].Name}): {price} Ft";
            cartLbx.Items.Add(text);
            label5.Text = $"Végösszeg: {TotalPrice().ToString("# ###")} Ft";
        }
    }
}
