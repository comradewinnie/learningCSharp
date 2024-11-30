using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 5;
            string password = "123que";
            string userInput;
            for (int i = 1; i <= triesCount; i++)
            {
                Console.Write("Введите ваш пароль: ");
                userInput = Console.ReadLine();
                if (i == 5)
                {
                    Console.WriteLine("Пароль неверный. Отказано в доступе.");
                    Console.ReadKey();
                    break;
                }
                if (userInput != password)
                {
                    Console.WriteLine("Пароль неверный. Попыток осталось: " + (5 - i));
                }
                else
                {
                    Console.WriteLine("Пароль верный. Добро пожаловать.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}