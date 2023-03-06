using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rendeles;
using fozde_koltsegek;
using fozde_termekek;
using kiszereles_torlo;

namespace Dashboard
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new kiszereles_torlo.Form1().Show();
        }
    }
}
