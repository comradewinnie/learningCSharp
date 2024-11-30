using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра 'Угадай число'!\nЗагадано число от 0 до 100. У вас 5 попыток, чтобы его отгадать.");
            Random randomizer = new Random();
            int randomValue = randomizer.Next(0,101);
            int userInput;

            for (int triesCount = 1; triesCount <= 5; triesCount++)
            {
                Console.Write("Какое число загадано? ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == randomValue)
                {
                    Console.WriteLine("Вы отгадали число!");
                    Console.ReadKey();
                    break;
                }
                if (triesCount == 5)
                {
                    Console.WriteLine($"Ответ неверный. Загаданное число - {randomValue}.");
                    Console.ReadKey();
                }
                if (userInput < randomValue)
                {
                    Console.WriteLine($"Загаданное число больше! Осталось попыток: {5 - triesCount}.");
                }
                else if (userInput > randomValue)
                {
                    Console.WriteLine($"Загаданное число меньше! Осталось попыток: {5 - triesCount}.");
                }
            }
        }
    }
}
