using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] books =
            {
                {"Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин"},
                {"Роберт Мартин", "Джесси Шелл", "Сергей Тепляков"},
                {"Стивен Кинг", "Говард Лавкрафт", "Брем Стокер"}
            };

            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 17);
                Console.WriteLine("\nВесь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.WriteLine(books[i, j]);
                    }
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать имя автора по индексу книги.\n2 - найти книгу по автору.\n3 - выход.");
                Console.Write("\nВыберите команду: ");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("\nВведите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine())-1;
                        Console.Write("Введите номер места: ");
                        column = Convert.ToInt32(Console.ReadLine())-1;
                        Console.WriteLine($"\nАвтор этой книги: {books[line, column]}.");
                        break;
                    case 2:
                        Console.Write("\nВведите автора: ");
                        string author = Console.ReadLine();
                        bool authorIsFound = false;
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (books[i, j].ToLower() == author.ToLower())
                                {
                                    Console.WriteLine("Книги автора " + author + " лежат на " + (i+1) + " полке и " + (j+1) + " месте.");
                                    authorIsFound = true;
                                    break;
                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.WriteLine("Вы неправильно ввели автора или у нас нет его книг.");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;
                }
                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
