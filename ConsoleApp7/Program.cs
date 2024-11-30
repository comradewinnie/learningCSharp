using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int playerDamage = 17;
            int enemyHealth = 100;
            int enemyDamage = 9;
            // Условие: игрок бьёт первым.
            while (enemyHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine("Здоровье противника: " + enemyHealth);
                Console.WriteLine("Для нанесения урона противнику нажмите любую клавишу.");
                Console.ReadKey();
                enemyHealth -= playerDamage;
                if (enemyHealth <= 0)
                {
                    break;
                }
                playerHealth -= enemyDamage;
                Console.WriteLine("Противник нанёс вам урон. Ваше здоровье: " + playerHealth);               
            }
            if (enemyHealth <= 0 && playerHealth <= 0)
            {
                Console.WriteLine("Ничья!");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Вы победили!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Вы проиграли!");
            }
            Console.ReadKey();
        }
    }
}