using System;

using System.Collections.Generic;

using System.Linq;
using System.Text;

using System.Threading.Tasks;


namespace Test

{
    
	class Program
    
	{
        
		static void Main(string[] args)

	        {
       string command = "Rotate(270)";

            		int from = command.IndexOf("(") + "(".Length;

           	        int to = command.LastIndexOf(")");

            		string comm = command.Substring(from, to - from);

                	Console.WriteLine(comm);

			
        	}
    
	}

}
