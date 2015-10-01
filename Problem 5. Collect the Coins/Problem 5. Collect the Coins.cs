using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Collect_the_Coins
{
    class CollectCoins
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                board[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    board[i][j] = input[j];
                }
            }
            string command = Console.ReadLine();
            int coins = 0;
            int wallHits = 0;
            int currRow = 0;
            int currCol = 0;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i]=='V')
                {
                    if ((currRow==3)||(board[currRow+1].Length<currCol+1))
                    {
                        wallHits++;
                    }
                    else
                    {
                        currRow++;
                        if (board[currRow][currCol]=='$')
                        {
                            coins++;
                        }
                    }
                }
                else if (command[i]=='^')
                {
                    if ((currRow==0)||(board[currRow-1].Length<currCol+1))
                    {
                        wallHits++;
                    }
                    else
                    {
                        currRow--;
                        if (board[currRow][currCol]=='$')
                        {
                            coins++;
                        }
                    }
                }
                else if (command[i]=='>')
                {
                    if (currCol==board[currRow].Length-1)
                    {
                        wallHits++;
                    }
                    else
                    {
                        currCol++;
                        if (board[currRow][currCol]=='$')
                        {
                            coins++;
                        }
                    }
                }
                else if (command[i]=='<')
                {
                    if (currCol==0)
                    {
                        wallHits++;
                    }
                    else
                    {
                        currCol--;
                        if (board[currRow][currCol]=='$')
                        {
                            coins++;
                        }
                    }
                }
            }
            Console.WriteLine("Coins collected: {0}",coins);
            Console.WriteLine("Walls hit: {0}",wallHits);
        }
    }
}
