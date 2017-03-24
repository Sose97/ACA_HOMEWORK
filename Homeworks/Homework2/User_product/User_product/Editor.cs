using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_product
{
    public class Editor : User
    {
        private string password { get; set; }
        private readonly static Editor[] mlist = new Editor[]
        {
            new Editor("edtior0","1234"),
            new Editor("editor1","123"),
            new Editor("editor2","12345"),
        };
        public Editor(string name, string password) : base(name)
        {
            this.password = password;
        }

        public override bool login()
        {
            for (int i = 0; i < mlist.Length; ++i)
            {
                if (mlist[i].password == this.password
                    )
                    return true;

            }
            return false;
        }
    }
}
