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
        public Users(User current)
        {
            InitializeComponent();
            users = users.Where(e => e.Name != current.Name && e.Permission != current.Permission).ToList();
            users.ForEach(e =>
            {
                listBox1.Items.Add(e.Name);
            });
        }
    }
}
