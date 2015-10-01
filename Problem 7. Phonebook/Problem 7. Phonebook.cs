using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some phonebook entries ( each on a separate line ) in the following format \"[name]-[phone number]\".");
            Console.WriteLine("When ready type \"search\" and enter some names.");
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            for (; ; )
            {
                string input = Console.ReadLine();
                if (input=="search")
                {
                    break;
                }
                string[] inputData = input.Split('-');
                if (phonebook.ContainsKey(inputData[0]))
                {
                    phonebook[inputData[0]].Add( inputData[1]);
                }
                else
	            {
                    phonebook.Add(inputData[0], new List<string>()); 
                    phonebook[inputData[0]].Add( inputData[1]);
	            }
            }
            Console.WriteLine("***************************");
            for (; ; )
            {
                string enteredName = Console.ReadLine();
                if (phonebook.ContainsKey(enteredName))
                {
                    foreach (var number in phonebook[enteredName])
                    {
                        Console.WriteLine("{0} -> {1}",enteredName, number);
                    }
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", enteredName);
                }
            }
        }
    }
}
