using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 1;
            string password = "123que";
            string enteredPassword;
            Console.Write("Введите ваш пароль: ");
            enteredPassword = Console.ReadLine();
            if (enteredPassword != password)
            {
                while (triesCount < 5)
                {
                    Console.WriteLine("Пароль неверный. Попыток осталось: " + (5 - triesCount));
                    Console.Write("Введите ваш пароль: ");
                    enteredPassword = Console.ReadLine();
                    triesCount++;
                }
                if (triesCount >= 5)
                {
                    Console.WriteLine("Пароль неверный. Отказано в доступе.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Пароль верный. Добро пожаловать.");
                Console.ReadKey();
            }
        }
    }
}