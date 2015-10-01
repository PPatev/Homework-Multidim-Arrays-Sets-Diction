using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Activity_Tracker
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedDictionary<int, SortedDictionary<string, List<int>>> data = new SortedDictionary<int, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string[] date = input[0].Split('/');
                int month = int.Parse(date[1]);
                int distance = int.Parse(input[2]);
                if (!data.ContainsKey(month))
                {
                    List<int> dist = new List<int>();
                    dist.Add(distance);
                    SortedDictionary<string, List<int>> names = new SortedDictionary<string, List<int>>();
                    names.Add(input[1], dist);
                    data.Add(month, names);
                }
                else
                {
                    if (!data[month].ContainsKey(input[1]))
                    {
                        List<int> dist = new List<int>();
                        dist.Add(distance);
                        data[month].Add(input[1], dist);
                    }
                    else
                    {
                        SortedDictionary<string, List<int>> names = data[month];
                        List<int> dist = names[input[1]];
                        dist.Add(distance);
                    }
                }
            }

            foreach (var month in data)
            {
                Console.Write("{0}: ",month.Key);
                var last = month.Value.Last();
                foreach (var name in month.Value)
                {
                    if (name.Equals(last))
                    {
                        Console.Write("{0}({1})", name.Key, name.Value.Sum());
                        break;
                    }
                    Console.Write("{0}({1}), ",name.Key,name.Value.Sum());
                    
                }
                Console.WriteLine();
            }
        }
    }
}
