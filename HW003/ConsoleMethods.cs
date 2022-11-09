using System;
using System.Collections.Generic;
using System.Text;

namespace HW003
{
    internal class ConsoleMethods
    {
        /// <summary>
        /// Печатает заголовок программы
        /// </summary>
        public static void PrintHeader()
        {
            Console.WriteLine("Программа для работы со Словарем Dictionary<T> (записная книжка с ФИО и номером телефона и ФИО)");
        }

        /// <summary>
        /// Печатает меню
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("1 - Добавить одно или несколько чисел в HashSet<int> ");
            Console.WriteLine("2 - Удалить одно или несколько чисел из HashSet<int> ");
            Console.WriteLine("3 - Вывести элементы HashSet<int> в консоль ");
            Console.WriteLine("q - Выйти из программы ");
        }

        /// <summary>
        /// Возвращает  строку введенную пользователем
        /// </summary>
        /// <returns></returns>
        public static string GetEnteredString()
        {
            string result = string.Empty;
            Console.WriteLine("Введите числа через запятую (или оставьте строку пустой) ");
            result = Console.ReadLine();
            return result;
        }

        /// <summary>
        /// Выводит сообщение, если число есть в множестве
        /// </summary>
        public static void AllReadyYet(int n)
        {
            Console.WriteLine($"Число {n} уже есть в множестве");
        }

        /// <summary>
        /// Выводит сообщение, если числа нет в множестве
        /// </summary>
        public static void AllReadyRemoved(int n)
        {
            Console.WriteLine($"Числа {n} нет в множестве");
        }

        /// <summary>
        /// Число успешно добавлено
        /// </summary>
        public static void NumberEdded(int n)
        {
            Console.WriteLine($"Число {n} Успешно добавлено");
        }

        /// <summary>
        /// Число успешно удалено
        /// </summary>
        public static void NumberRemoved(int n)
        {
            Console.WriteLine($"Число {n} Успешно удалено");
        }

        /// <summary>
        /// Получает параметры для удаления или добавления
        /// </summary>
        /// <returns></returns>
        public static HashSet<int> GetAddedParams()
        {
            HashSet<int> Hashlist = new HashSet<int>();
            string[] nums = (GetEnteredString().Replace(" ", "")).Split(",");
            Console.WriteLine();
            Hashlist.Clear();
            foreach (var item in nums)
            {
                
                if (Hashlist.Contains(Convert.ToInt32(item)))
                {
                    AllReadyYet(Convert.ToInt32(item));
                }
                else
                {
                    Hashlist.Add(Convert.ToInt32(item));
                    NumberEdded(Convert.ToInt32(item));
                }
            }
            return Hashlist;
        }

        /// <summary>
        /// Получает параметры для удаления или добавления
        /// </summary>
        /// <returns></returns>
        public static HashSet<int> GetRemovedParams()
        {
            HashSet<int> Hashlist = new HashSet<int>();
            string[] nums = (GetEnteredString().Replace(" ", "")).Split(",");
            Console.WriteLine();
            Hashlist.Clear();
            foreach (var item in nums)
            {

                if (Hashlist.Contains(Convert.ToInt32(item)))
                {
                    AllReadyRemoved(Convert.ToInt32(item));
                }
                else
                {
                    Hashlist.Add(Convert.ToInt32(item));
                    NumberRemoved(Convert.ToInt32(item));
                }
            }
            return Hashlist;
        }

    }
}
