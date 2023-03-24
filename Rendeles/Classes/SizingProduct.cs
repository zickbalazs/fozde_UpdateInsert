using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rendeles.Classes
{
    class SizingProduct
    {
        public int ID;
        public int SizingID;
        public int ProductID;

        public SizingProduct(int iD, int sizingID, int productID)
        {
            ID = iD;
            SizingID = sizingID;
            ProductID = productID;
        }
    }
}
