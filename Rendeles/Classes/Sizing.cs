using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendeles.Classes
{
    class Sizing
    {
        public int ID;
        public string Name;
        public double AmountInLitres;
        public Sizing(int iD, string name, double amountInLitres)
        {
            ID = iD;
            Name = name;
            AmountInLitres = amountInLitres;
        }
    }
}
