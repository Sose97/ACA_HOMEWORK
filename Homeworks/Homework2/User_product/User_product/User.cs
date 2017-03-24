using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_product
{
    public abstract class User
    {
        public string name { get; set; }
        public User(string s)
        {
            name = s;
        }
        public abstract bool login();
    }
}
