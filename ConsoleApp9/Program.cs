using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            float health1 = random.Next(90,101);
            int damage1 = random.Next(10, 31);
            int armor1 = random.Next(25, 65);

            float health2 = random.Next(90, 101);
            int damage2 = random.Next(10, 31);
            int armor2 = random.Next(25, 65);

            Console.WriteLine("              Здоровье    Урон    Броня");
            Console.Write("Гладиатор 1");
            Console.WriteLine($"      {health1}        {damage1}      {armor1}");
            Console.Write("Гладиатор 2");
            Console.WriteLine($"      {health2}        {damage2}      {armor2}");
            Console.WriteLine("Нажмите любую клавишу, чтобы начать бой!");
            Console.ReadKey();

            while (health1 > 0 && health2 > 0) 
            {
                health1 -= Convert.ToSingle(damage2) / 100 * armor1;
                health2 -= Convert.ToSingle(damage1) / 100 * armor2;
                if (health1 <= 0 && health2 <= 0)
                {
                    Console.WriteLine("Ничья!");
                    Console.ReadKey();
                    break;
                }
                else if (health1 <= 0)
                {
                    Console.WriteLine("Победил гладиатор 2!");
                    Console.ReadKey();
                    break;
                }
                else if (health2 <= 0)
                {
                    Console.WriteLine("Победил гладиатор 1!");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("              Здоровье");
                Console.Write("Гладиатор 1");
                Console.WriteLine($"      {health1}");
                Console.Write("Гладиатор 2");
                Console.WriteLine($"      {health2}");
                Console.WriteLine("Нажмите любую клавишу для следующего хода!");
                Console.ReadKey();
            }
            
            
        }
    }
}
