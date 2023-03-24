using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiszereles_torlo
{
    class TermekKiszereles
    {
        public int ID;
        public int productID;
        public int sizingID;
        public TermekKiszereles(int id, int productid, int sizingid)
        {
            ID = id;
            productID = productid;
            sizingID = sizingid;
        }
    }
}
