using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fozde_termekek
{
    class Termek
    {
        public int ID;
        public string nev;
        public int evjarat;
        public double erosseg;
        public int literAr;
        public List<TermekKiszereles> TermekKiszerelesek;
        public Termek(int id, string nev, int evjarat, double erosseg, int literar)
        {
            TermekKiszerelesek = new List<TermekKiszereles>();
            ID = id;
            this.nev = nev;
            this.evjarat = evjarat;
            this.erosseg = erosseg;
            literAr = literar;
        }
        public List<Kiszereles> GetKiszerelesek(List<TermekKiszereles> termekKiszereles, List<Kiszereles> kiszerelesek)
        {
            TermekKiszerelesek.Clear();
            List<Kiszereles> ksz = new List<Kiszereles>();

            termekKiszereles.Where(e => e.termekID == ID).ToList().ForEach(t =>
            {
                ksz.Add(kiszerelesek.Find(h => h.ID == t.mertekID));
                termekKiszereles.Add(t);
            });

            return ksz;
        }
    }
}
