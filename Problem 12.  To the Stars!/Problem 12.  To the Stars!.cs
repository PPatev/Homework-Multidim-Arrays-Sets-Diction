using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.To_the_Stars_
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            string[] stars = new string[3];
            double[,] coorStars = new double[3, 2];
            double[] coor = new double[2];
            
            for (int i = 0; i < 3; i++)
            {
                string[] star = Console.ReadLine().Split(' ');
                stars[i] = star[0].ToLower();
                coorStars[i, 0] = 30 - double.Parse(star[2]);
                coorStars[i, 1] = double.Parse(star[1]) - 1;
            }
            string[] coordinates = Console.ReadLine().Split(' ');
            coor[0] = 30 - double.Parse(coordinates[1]);
            coor[1] = double.Parse(coordinates[0]) - 1;
            int moves = int.Parse(Console.ReadLine());
            //int[,] grid = new int[30, 30];
            double rowMove = coor[0];
            for (int k = 0; k <= moves; k++)
			{
                string output = ""; 
			    for (int i = 0; i < coorStars.GetLength(0); i++)
			    {
			        if ((rowMove<=coorStars[i,0]+1)
                        && (rowMove >= coorStars[i, 0] - 1))
	                {
                        if ((coor[1] >= coorStars[i, 1] - 1)
                            && (coor[1] <= coorStars[i, 1] + 1))
                        {
                            output = stars[i];
                            break;
                        }
                        else
                        {
                            output = "space";
                        }
	                }
                    else
	                {
                        output = "space";
	                }
			    }
                Console.WriteLine(output);
                rowMove--;
			}
            
        }
    }
}
