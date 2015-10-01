using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Terrorists_Win_
{
    class TerroristsWin
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int bombPower = 0;
            bool bombStart = false;
            Dictionary<int, int> startEndPos = new Dictionary<int, int>();
            int startPos = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i]=='|')&&(!bombStart))
                {
                    bombStart = true;
                    startPos = i;
                }
                else if ((text[i]=='|')&&(bombStart))
                {
                    bombStart = false;
                    bombPower = ((bombPower-124) % 10);
                    startEndPos.Add((startPos - bombPower) , (i+bombPower));
                    bombPower = 0;
                    startPos = 0;
                }

                if (bombStart)
                {
                    bombPower += (int)text[i];
                }
               
                result.Append(text[i]);
               
            }

            foreach (var start in startEndPos)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if ((i>=start.Key)&&(i<=start.Value))
                    {
                        result[i] = '.';
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
