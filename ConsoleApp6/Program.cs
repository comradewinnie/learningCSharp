using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float investedMoney;
            float percentPerYear = 11.6f;
            int numberOfYears;
            int convertPercentToDecimal = 100;
            Console.WriteLine($"Добро пожаловать в банк. Мы предлагаем вклады под {percentPerYear}% годовых.");
            Console.Write("Введите сумму EUR, которую вы хотите вложить: ");
            investedMoney = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество лет: ");
            numberOfYears = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш вклад составляет {investedMoney} EUR на срок {numberOfYears} год(-а)/лет.");
            Console.WriteLine("Таблица накоплений:");
            for (int year = 1; year <= numberOfYears; year++)
            {
                Console.WriteLine($"{year} год: {investedMoney+=investedMoney*(percentPerYear/convertPercentToDecimal)} EUR");
                Console.ReadKey();
            }
        }
    }
}
