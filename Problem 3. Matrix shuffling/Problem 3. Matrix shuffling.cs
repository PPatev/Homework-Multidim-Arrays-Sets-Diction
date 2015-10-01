using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Matrix_shuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            ShufflingTheMatrix(matrix);
        }
        static void ShufflingTheMatrix(string[,] matrix)
        {
            for (; ; )
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0]=="END")
                {
                    break;
                }
                else if ((input[0]=="swap")&&(int.Parse(input[1])<matrix.GetLength(0))&&
                    (int.Parse(input[1])>=0)&&(int.Parse(input[2])<matrix.GetLength(1))&&
                    (int.Parse(input[2]) >= 0) && (int.Parse(input[3]) < matrix.GetLength(0))&&
                    (int.Parse(input[3]) >= 0)&&(int.Parse(input[4])<matrix.GetLength(1))&&
                    (int.Parse(input[4]) >= 0))
                {
                    string swap = matrix[int.Parse(input[1]), int.Parse(input[2])];
                    matrix[int.Parse(input[1]), int.Parse(input[2])] = matrix[int.Parse(input[3]), int.Parse(input[4])];
                    matrix[int.Parse(input[3]), int.Parse(input[4])] = swap;
                    PrintStringMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        
        }

        static void PrintStringMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
