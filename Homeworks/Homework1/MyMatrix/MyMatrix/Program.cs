using System;

namespace MyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            // First Matrix
            MyMatrix m1 = new MyMatrix(3, 2);
            m1.InputMatrixValues();
            m1.PrintMatix();

            Console.WriteLine();


            // Second Matrix
            MyMatrix m2 = new MyMatrix(2, 4);
            m2.InputMatrixValues();
            m2.PrintMatix();

            Console.WriteLine();


            // Product matrix
            (MyMatrix.Multiply(m1, m2)).PrintMatix();


            Console.Read();
        }
    }
}
