using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "123que";
            string userInput;
            for (int triesCount = 1; triesCount <= 5; triesCount++)
            {
                Console.Write("Введите ваш пароль: ");
                userInput = Console.ReadLine();
                if (triesCount == 5)
                {
                    Console.WriteLine("Пароль неверный. Отказано в доступе.");
                    Console.ReadKey();
                    break;
                }
                if (userInput != password)
                {
                    Console.WriteLine("Пароль неверный. Попыток осталось: " + (5 - triesCount));
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