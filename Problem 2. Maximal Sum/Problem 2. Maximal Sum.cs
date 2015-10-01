using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Maximal_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] rowCol = Console.ReadLine().Split(' ');
            int n = int.Parse(rowCol[0]);
            int m = int.Parse(rowCol[1]);
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] colNums = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(colNums[j]);
                }
                
            }
            //int dimension = int.Parse(Console.ReadLine());
            MaximalSumInMatrix(matrix,3);
        }

        static void MaximalSumInMatrix(int[,] matrix, int dimen)
        {
            int sum = 0;
            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;
            for (int i = 0; i < matrix.GetLength(0)- dimen + 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)- dimen + 1; j++)
                {
                    for (int k = 0; k < dimen; k++)
                    {
                        for (int l = 0; l < dimen; l++)
                        {
                            sum += matrix[i + k, j + l];
                        }
                    }

                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                    sum = 0;
                }
            }
            PrintMaxBlock(matrix, row, col, dimen, maxSum);
        }

        static void PrintMaxBlock(int[,] someMatrix, int someRow, int someCol, int someDimen, int someSum)
        {
            Console.WriteLine();
            Console.WriteLine("Sum = {0}",someSum);
            Console.WriteLine();
            for (int i = someRow; i < someDimen +1; i++)
            {
                for (int j = someCol; j < someDimen +1; j++)
                {
                    Console.Write("{0,-5}",someMatrix[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
