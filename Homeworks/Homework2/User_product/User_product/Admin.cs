using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_product
{
    public class Admin : User
    {
        public string Password { get; set; }
        public string SecretKey { get; set; }
        
        private readonly static Admin[] mlist = new Admin[]
        {
            new Admin("admin0","1234","tiger"),
            new Admin("admin1","123","lion")
        };

        public Admin(string name, string password, string secretkey):base(name)
        {
            this.Password = password;
            this.SecretKey = secretkey;
        }

        public override bool login()
        {
            for(int i=0;i<mlist.Length;++i)
            {
                if (mlist[i].Password == this.Password && mlist[i].SecretKey == this.SecretKey
                    && mlist[i].name == this.name)
                    return true;

            }
            return false;
            
        }
    }
}
