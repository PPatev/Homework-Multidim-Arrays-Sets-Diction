using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sequence_in_Matrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m :");
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];
            Console.WriteLine("Enter values for the matrix, each row on a single line, values separeted by space:");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int count = 1;
            int maxCount = 1;
            string str = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            str = matrix[i, j];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                count = 1;

            }

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (matrix[i, j] == matrix[i + 1, j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            str = matrix[i, j];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                count = 1;
            }

            int num = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    while ((i + num < n) && (j + num < m))
                    {
                        if (matrix[i, j] == matrix[i + num, j + num])
                        {
                            count++;
                            if (count > maxCount)
                            {
                                maxCount = count;
                                str = matrix[i, j];
                            }
                        }
                        else
                        {
                            count = 1;
                        }
                        num++;
                    }
                    count = 1;
                    num = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    while ((i + num < n) && (j - num >= 0))
                    {
                        if (matrix[i, j] == matrix[i + num, j - num])
                        {
                            count++;
                            if (count > maxCount)
                            {
                                maxCount = count;
                                str = matrix[i, j];
                            }
                        }
                        else
                        {
                            count = 1;
                        }
                        num++;
                    }
                    count = 1;
                    num = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i == maxCount - 1)
                {
                    Console.WriteLine(str);
                    break;
                }
                Console.Write(str + ", ");
            }
        }
    }
}
