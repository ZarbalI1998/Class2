using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class._1
{
    internal class User:Human
    {
       public string UserName;
        public string Password;

        public User(string userName, string password,):base(userName,password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
