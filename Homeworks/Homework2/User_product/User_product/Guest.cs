using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_product
{
    public class Guest : User
    {
        public Guest(string s) : base(s)
        {
        }

        public override bool login()
        {
            return true;
        }
    }
}
