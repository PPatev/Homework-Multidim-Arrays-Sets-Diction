using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Night_Life
{
    class NightLife
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> cities = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            Console.WriteLine("Enter city;venue;performer: ");

            for (; ; )
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] inputData = input.Split(';');
                if (!cities.ContainsKey(inputData[0]))
                {
                    SortedSet<string> performers = new SortedSet<string>();
                    performers.Add(inputData[2]);
                    SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>();
                    venues.Add(inputData[1], performers);
                    cities.Add(inputData[0], venues);
                }
                else
                {
                    if (!cities[inputData[0]].ContainsKey(inputData[1]))
                    {
                        SortedSet<string> performers = new SortedSet<string>();
                        performers.Add(inputData[2]);
                        cities[inputData[0]].Add(inputData[1],performers);
                    }
                    else
                    {
                        SortedDictionary<string, SortedSet<string>> venues = cities[inputData[0]];
                        SortedSet<string> performers = venues[inputData[1]];
                        performers.Add(inputData[2]);
                    }
                }
            }

            foreach (var city in cities)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    Console.WriteLine("->{0}: {1}", venue.Key, string.Join(",",venue.Value));
                }
            }
       


        }
    }
}
