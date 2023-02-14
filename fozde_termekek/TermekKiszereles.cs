using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek
{
    class TermekKiszereles
    {
        public int ID, termekID, mertekID;
        public TermekKiszereles(int id, int termekid, int mertekid)
        {
            ID = id;
            termekID = termekid;
            mertekID = mertekid;
        }
    }
}
