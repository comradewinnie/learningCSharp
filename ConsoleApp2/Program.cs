using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float amperage;
            float resistance;
            float voltage;

            Console.WriteLine("Программа по вычислению силы тока, зная напряжение и сопротивление");

            Console.Write("Введите напряжение (В): ");
            voltage = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите сопротивление (Ом): ");
            resistance = Convert.ToSingle(Console.ReadLine());

            amperage = voltage / resistance;

            Console.WriteLine($"Сила тока равна {amperage} А.");
            Console.ReadKey();
        }
    }
}
