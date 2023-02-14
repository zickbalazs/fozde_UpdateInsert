using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek
{
    class Kiszereles
    {
        public int ID;
        public string Nev;
        public double Amount;

        public Kiszereles(int id, string nev, double amount)
        {
            ID = id;
            Nev = nev;
            Amount = amount;
        }
    }
}
