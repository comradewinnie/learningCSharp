using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array1 = new string[3, 5] {
                {"hello", "hi", "goodbye", "bye", "hey"},
                {"buddy", "comrade", "friend", "homie", "bro"},
                {"good", "bad", "lucky", "excellent", "positive"}
            };
            int[,] array2 =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            //Console.WriteLine(array2[2, 1]);
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
