using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class User
    {
        private int id;
        public string Name;
        public string password;
        public int Permission;
        public User(int id, string name, string password, int perm)
        {
            this.id = id;
            Name = name;
            this.password = password;
            Permission = perm;
        }
        public int getID() => id;
    }
}
