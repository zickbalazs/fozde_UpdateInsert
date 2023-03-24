using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendeles.Classes
{
    class Product
    {
        public int ID;
        public string Name;
        public int Year;
        public double Alcohol;
        public double UnitPrice;
        public List<Sizing> Sizings = new List<Sizing>();

        public Product(int iD, string name, int year, double alcohol, double unitPrice)
        {
            ID = iD;
            Name = name;
            Year = year;
            Alcohol = alcohol;
            UnitPrice = unitPrice;
        }
        public void LinqConnection(List<Sizing> sizings, List<SizingProduct> sizingProducts)
        {
            sizingProducts.Where(h => h.ProductID == this.ID).ToList().ForEach(g=> 
            {
                Sizings.Add(sizings.Find(e => e.ID == g.SizingID));
            });
        }
    }
}
