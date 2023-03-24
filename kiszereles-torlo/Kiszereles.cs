using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiszereles_torlo
{
    class Kiszereles
    {
        public int ID;
        public string unitName;
        public double Amount;
        public Kiszereles(int id, string unitname, double amount)
        {
            ID = id;
            unitName = unitname;
            Amount = amount;
        }
    }
}
