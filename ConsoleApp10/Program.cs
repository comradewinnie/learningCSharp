using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cucumbers = new int[5] { 2, 1, 5, 76, 25 };
            int sum = 0;
            for (int i = 0; i < cucumbers.Length; i++)
            {
                Console.WriteLine("Число: " + cucumbers[i]);
                sum += cucumbers[i];
                Console.WriteLine($"Сумма чисел: {sum}");
                Console.ReadKey();
            }

            int maxElement = int.MinValue;
            for (int k = 0; k < cucumbers.Length; k++)
            {
                if (maxElement < cucumbers[k])
                {
                    maxElement = cucumbers[k];
                }
            }
            Console.WriteLine(maxElement);
            Console.ReadKey();
        }
    }
}
