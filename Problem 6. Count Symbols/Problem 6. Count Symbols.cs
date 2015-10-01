using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Count_Symbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedSet<char> sortedLetters = new SortedSet<char>();
            for (int i = 0; i < text.Length; i++)
            {
                sortedLetters.Add(text[i]);
            }
            int count = 0;
            foreach (var item in sortedLetters)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (item == text[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0}: {1} time/s",item,count);
                count = 0;
            }
        }
    }
}
