using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 16, 17 }; // количество мест в разных секторах самолёта, всего секторов 5
            int chosenSector = int.MinValue;
            while (true)
            {
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }
                Console.Write("В каком секторе Вы хотите купить билет? ");
                chosenSector = Convert.ToInt32(Console.ReadLine()) - 1;
                if (sectors[chosenSector] > 0)
                {
                    sectors[chosenSector] -= 1;
                    Console.WriteLine("Билет куплен!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Свободных билетов в этом секторе не осталось. Билет не куплен!");
                    Console.ReadKey();
                }
                Console.Clear();
            }

        }
    }
}
