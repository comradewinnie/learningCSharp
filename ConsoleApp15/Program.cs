using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','X','#',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#','#','#',' ',' ','#'},
                {'#',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ','#',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#','#',' ','#'},
                {'#',' ',' ','#','#',' ',' ','#','#','#','#',' ',' ',' ','#',' ','#'},
                {'#',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#'},
                {'#',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ','X',' ','#','#','#'},
                {'#',' ',' ',' ','#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#'},
                {'#','X',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','X',' ','#',' ',' ','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ','X','#'},
                {'#',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

            int userX = 5, userY = 3;

            char[] bag = new char[1];

            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка:");
                for (int b = 0; b < bag.Length; b++)
                {
                    Console.Write(bag[b] + " ");
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX);
                Console.Write("@");
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }
                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int l = 0; l < bag.Length; l++)
                    {
                        tempBag[l] = bag[l];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
