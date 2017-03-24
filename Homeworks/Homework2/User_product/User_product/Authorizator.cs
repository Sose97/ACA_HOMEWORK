using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_product
{
    public class Authorizator
    {
        private User obj;
        public Authorizator(User o)
        {
            this.obj = o;
        }

        public bool acsepted()
        {
            return obj.login();
        }
    }
}
