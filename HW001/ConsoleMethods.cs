using System;
using System.Collections.Generic;
using System.Text;

namespace HW001
{
    internal class ConsoleMethods
    {
        public static void PrintHeader()
        {
            Console.WriteLine("Программа для работы с коллекцией List<T>");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1 - Заполнить Коллекцию случайными данными ");
            Console.WriteLine("2 - Вывести коллекцию в консоль ");
            Console.WriteLine("3 - Удалить из коллекции числа из диапазона (25; 50) ");
            Console.WriteLine("4 - Удалить из коллекции числа из диапазона, указанного вручную ");
            Console.WriteLine("q - Выйти из программы ");
        }

        public static void GetStart()
        {
            Console.WriteLine("Запустить программу? (y/n)");
        }

        public static void PrintStars()
        {
            Console.WriteLine("*****************************");
        }

        public static string UserChoice { get; set; }

        
    }
}
