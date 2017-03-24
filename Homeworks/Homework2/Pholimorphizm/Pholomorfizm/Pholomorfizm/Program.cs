using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Pholomorfizm
{

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass temp1 = new BaseClass();
            BaseClass temp2 = new DeliveredClass();
            DeliveredClass temp3 = new DeliveredClass();

            temp1.method1();
            temp2.method1();
            temp3.method1();
            temp3.method1("Hello");
        }
    }
}
