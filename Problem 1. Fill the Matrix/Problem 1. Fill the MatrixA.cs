using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Fill_the_Matrix
{
    class FillMatrixA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,-5}",matrix[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
