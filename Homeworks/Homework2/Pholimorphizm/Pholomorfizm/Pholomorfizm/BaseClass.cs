using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pholomorfizm
{
   public class BaseClass
    {
        public void method1()
        {
            Console.WriteLine("Base method");
        }
    };

    public class DeliveredClass:BaseClass
    {
        public void method1(string x)
        {
            Console.WriteLine(x+"Delivered metod");
        }
    }
}
