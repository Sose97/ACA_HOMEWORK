using System;

namespace MyMatrix
{
    public class MyMatrix
    {
        private readonly int rowLength;

        public int GetRowLength()
        {
            return rowLength;
        }

        private readonly int colLength;

        public int GetColLength()
        {
            return colLength;
        }

        private readonly double[,] data;

        public double[,] GetData()
        {
            return data;
        }

        public MyMatrix(int rowLength, int colLength)
        {
            this.rowLength = rowLength;
            this.colLength = colLength;

            data = (new double[GetRowLength(), GetColLength()]);
        }


        // Input Matrix Values
        public void InputMatrixValues()
        {
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.WriteLine(string.Format("Matrix[{0},{1}] = ",i,j));
                    data[i, j] = double.Parse(Console.ReadLine()); // TODO manage exeptions and bugs
                }
            }
        }


        // Print matrix values
        public void PrintMatix()
        {
            Console.WriteLine();
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(data[i, j]);
                    Console.Write("        ");
                }
                Console.WriteLine();
            }
        }


        static public MyMatrix Multiply(MyMatrix matrix_1, MyMatrix matrix_2)
        {
            // Make sure matrixes can be multiplied together
            if (matrix_1.GetColLength() != matrix_2.GetRowLength())
                throw new ArgumentException("Matrixes cannot be multiplied together because the number of columns in the first matrix doesn't equal the number of rows in the second matrix.");

            // The result matrix
            MyMatrix result = new MyMatrix(matrix_1.GetRowLength(), matrix_2.GetColLength());


            // Do the multiplication
            for (int i = 0; i < result.GetRowLength(); i++)
            {
                for (int j = 0; j < result.GetColLength(); j++)
                {
                    result.GetData()[i, j] = 0;
                    for (int k = 0; k < matrix_1.GetColLength(); k++)
                    {
                        result.GetData()[i, j] += matrix_1.GetData()[i, k] * matrix_2.GetData()[k, j];
                    }
                }
            }


            return result;
        }
    }
}
