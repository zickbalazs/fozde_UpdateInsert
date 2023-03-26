using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fozde_termekek;
using fozde_koltsegek;
using kiszereles_torlo;

namespace Dashboard
{
    public partial class Menu : Form
    {
        private User user;
        public Menu(User user)
        {
            InitializeComponent();
            Text = $"Üdv, {user.Name}";
            this.user = user;
            if (user.Permission == 1)
            {
                button2.Visible = false;
            }
            if (user.Permission == 2)
            {
                button2.Visible = false;
                button4.Visible = false;
                button1.Visible = false;
                button5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new kiszereles_torlo.Form1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Rendeles.Form1().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new fozde_termekek.Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Users(user).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new fozde_koltsegek.Form1().Show();
        }
    }
}
