using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Plus_Remove
{
    class PlusRemove
    {
        static void Main(string[] args)
        {
            List<List<char>> input = new List<List<char>>();
            SortedDictionary<int, SortedSet<int>> positions = new SortedDictionary<int, SortedSet<int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="END")
                {
                    break;
                }
                List<char> lineChars = new List<char>();
                for (int i = 0; i < line.Length; i++)
                {
                    lineChars.Add(line[i]);
                }
                input.Add(lineChars);
            }

            for (int i = 0; i < input.Count-2; i++)
            {
                for (int j = 1; j < input[i].Count; j++)
                {
                    if ((j+1<input[i+1].Count)&&(j<input[i+2].Count))
                    {
                        if (((input[i][j] == input[i + 1][j]) || (input[i][j] == input[i + 1][j] - 32) || (input[i][j] == input[i + 1][j]+32))
                           && ((input[i][j] == input[i + 2][j]) || (input[i][j] == input[i + 2][j] - 32) || (input[i][j] == input[i + 2][j]+32))
                           && ((input[i][j] == input[i + 1][j - 1]) || (input[i][j] == input[i + 1][j - 1] - 32) || (input[i][j] == input[i + 1][j - 1]+32))
                           && ((input[i][j] == input[i + 1][j + 1]) || (input[i][j] == input[i + 1][j + 1] - 32) || (input[i][j] == input[i + 1][j + 1]+32)))
                                {
                                    if (positions.ContainsKey(i))
                                    {
                                        positions[i].Add(j);
                                    }
                                    else
                                    {
                                        SortedSet<int> cols = new SortedSet<int>();
                                        cols.Add(j);
                                        positions.Add(i, cols);
                                    }
                                    if (positions.ContainsKey(i+1))
                                    {
                                        positions[i+1].Add(j);
                                        positions[i + 1].Add(j-1);
                                        positions[i + 1].Add(j+1);
                                    }
                                    else
                                    {
                                        SortedSet<int> cols = new SortedSet<int>();
                                        cols.Add(j);
                                        cols.Add(j-1);
                                        cols.Add(j+1);
                                        positions.Add(i+1, cols);
                                    }
                                    if (positions.ContainsKey(i+2))
                                    {
                                        positions[i+2].Add(j);
                                    }
                                    else
                                    {
                                        SortedSet<int> cols = new SortedSet<int>();
                                        cols.Add(j);
                                        positions.Add(i+2, cols);
                                    }
                                }
                    }
                }
            }
            foreach (var row in positions)
            {
                StringBuilder rowLine = new StringBuilder();
                List<char> rows = input[row.Key].ToList();
                for (int i = 0; i < rows.Count; i++)
                {
                    if (row.Value.Contains(i))
                    {
                        continue;
                    }
                    rowLine.Append(rows[i]);
                }
                //foreach (var col in row.Value)
                //{
                //    rowLine.Remove(col);
                //}
               Console.WriteLine(rowLine.ToString());
               
            }

        }
    }
}
