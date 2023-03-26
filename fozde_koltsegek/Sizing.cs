using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_koltsegek
{
    internal class Sizing
    {
        public int ID;
        public string Name;
        public double Size;
        public Sizing(int iD, string name, double size)
        {
            ID = iD;
            Name = name;
            Size = size;
        }
    }
}
