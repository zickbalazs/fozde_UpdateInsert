using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiszereles_torlo
{
    class Termek
    {
        public int ID;
        public string Name;
        public int Year;
        public double Alcohol;
        public double Price;
        public Termek(int id, string name, int year, double alcohol, double price)
        {
            ID = id;
            Name = name;
            Year = year;
            Alcohol = alcohol;
            Price = price;
        }
    }
}
