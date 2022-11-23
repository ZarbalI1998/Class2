using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._1
{
    internal class Admin : Human
    {
        public string Section;
        public bool IsSuperAdmin;

        public Admin(string username, string password, string section, bool isSuperAdmin)
        {
            Section = section;
            IsSuperAdmin = isSuperAdmin;
            Username = username;
            Password = password;


        }
    }
}
