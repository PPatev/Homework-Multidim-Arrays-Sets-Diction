using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.String_Matrix_Rotation
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<List<char>> input = new List<List<char>>();
            int maxLength = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END") 
                {
                    break;
                }
                if (line.Length>maxLength)
                {
                    maxLength = line.Length;
                }
                List<char> lineTxt = new List<char>();
                for (int i = 0; i < line.Length; i++)
                {
                    lineTxt.Add(line[i]);
                }
                input.Add(lineTxt);
            }
            char[,] matrix = new char[input.Count, maxLength];
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < maxLength; j++)
                {
                    if (j>=input[i].Count)
                    {
                        matrix[i, j] = '\0';
                    }
                    else
                    {
                        matrix[i, j] = input[i][j];
                    }
                    
                }
            }
            int from = command.IndexOf("(") + "(".Length;
            int to = command.LastIndexOf(")");
            string comm = command.Substring(from, to - from);
            int timesRotate = int.Parse(comm) / 90;

            for (int k = 0; k < timesRotate; k++)
            {
                char[,] newMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int i = matrix.GetLength(0)-1; i >= 0; i--)
                    {
                        newMatrix[j,matrix.GetLength(0)-1-i] = matrix[i, j];
                    }
                }
                matrix = newMatrix;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
