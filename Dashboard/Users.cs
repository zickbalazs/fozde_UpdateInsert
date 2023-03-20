using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Users : Form
    {
        List<User> users = DB.GetUsers();
        User Selected;
        public Users(User current)
        {
            InitializeComponent();
            users = users.Where(e => e.Name != current.Name && e.Permission != current.Permission).ToList();
            users.ForEach(e =>
            {
                listBox1.Items.Add(e.Name);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DB.DeleteUser(Selected.getID()))
                MessageBox.Show("Sikeres törlés!");
            else MessageBox.Show("Sikertelen törlés!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DB.ModUser(new User(Selected.getID(), nameTbx.Text, passTbx.Text, Convert.ToInt32(permTbx.Text))))
                MessageBox.Show("Sikeres módosítás");
            else MessageBox.Show("Sikertelen módosítás");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected = users[listBox1.SelectedIndex];
            nameTbx.Text = Selected.Name;
            permTbx.Text = Selected.Permission.ToString();
            passTbx.Text = Selected.password;
        }
    }
}
