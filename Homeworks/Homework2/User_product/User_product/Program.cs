using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace User_product
{
    class Program
    {
        private static void start()
        {

            Console.WriteLine("If you are Admin press 1");
            Console.WriteLine("If you are Editor press 2");
            Console.WriteLine("If you are Guest press 3");
            Authorizator x;
            switch (Convert.ToInt32(Console.ReadLine()))
            { 
                case 1:
                String name, password, secretkey;
                Console.WriteLine("Login");
                name=Console.ReadLine();
                Console.WriteLine("Password");
                password = Console.ReadLine();
                Console.WriteLine("Secret key");
                secretkey = Console.ReadLine();
                User admin = new Admin(name,password,secretkey);
                x = new Authorizator(admin);
                if (x.acsepted())
                {
                    Print();
                }
                break;
                case 2:
                String Ename, Epassword;
                Console.WriteLine("Login");
                Ename = Console.ReadLine();
                Console.WriteLine("Password");
                Epassword = Console.ReadLine();
                User editor = new Editor(Ename,Epassword);
                x = new Authorizator(editor);
                if (x.acsepted())
                {
                    Print();
                }
                break;
                case 3:
                String gname = Console.ReadLine();
                User guest = new Guest(gname);
                x = new Authorizator(guest);
                if (x.acsepted())
                {
                    Print();
                }
                break;
             }
        }

        private static void Print()
        {
            Console.WriteLine("Input message");
            Console.WriteLine("Press 1 for exit");
                      
            if (Convert.ToInt32(Console.ReadLine())==1)
            {
                start();
            }

        }
        static void Main(string[] args)
        {
            start();
            
        }
    }
}
