using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fozde_termekek
{
    public partial class Form1 : Form
    {
        static List<Termek> termekek = dbGet.Termekek();
        static List<TermekKiszereles> termekkiszerelesek = dbGet.TermekKiszerelesek();
        static List<Kiszereles> kiszerelesek = dbGet.Kiszerelesek(), selectedKiszerelesek = new List<Kiszereles>();
        public Form1()
        {
            InitializeComponent();
            SetKiszerelesek();
            SetTermekek();
        }
        private void SetTermekek() => termekek.ForEach(e =>
        {
            comboBox2.Items.Add(e.nev);
        });
        private void SetKiszerelesek()
        {
            foreach (Kiszereles kiszereles in kiszerelesek)
            {
                comboBox1.Items.Add(kiszereles.Nev);
                comboBox3.Items.Add(kiszereles.Nev);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dbInsert.toTermekek(new Termek(termekek.Count+1, newName.Text, Convert.ToInt32(newYear.Text), Convert.ToDouble(newStrength.Text), Convert.ToInt32(newLitrePrice.Text)), kiszerelesek[comboBox1.SelectedIndex]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = termekek[comboBox2.SelectedIndex].ID, year = Convert.ToInt32(modYear.Text);
            string name = modName.Text;
            double strength = Convert.ToDouble(modStrength.Text);
            int literAr = Convert.ToInt32(modLitres.Text);

            dbUpdate.Termekek(new Termek(ID, name, year, strength, literAr));
        }

        private void modSizing_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            modSizing.Items.Clear();
            
            modName.Text = termekek[comboBox2.SelectedIndex].nev;
            modLitres.Text = termekek[comboBox2.SelectedIndex].literAr.ToString();
            modStrength.Text = termekek[comboBox2.SelectedIndex].erosseg.ToString();
            modYear.Text = termekek[comboBox2.SelectedIndex].evjarat.ToString();
            
            selectedKiszerelesek = termekek[comboBox2.SelectedIndex].GetKiszerelesek(termekkiszerelesek, kiszerelesek);
            selectedKiszerelesek.ForEach(t => { modSizing.Items.Add(t.Nev); } );
        }
    }
}
