using System;
using System.Collections.Generic;
using System.Text;

namespace HW002
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
            Console.WriteLine("1 - Начать заполнение Записной книжки ");
            Console.WriteLine("2 - Вывести коллекцию в консоль ");
            Console.WriteLine("3 - Вывести пользователя по номеру телефона в консоль ");
            Console.WriteLine("q - Выйти из программы ");
        }

        /// <summary>
        /// Печатает приглашение в консоль
        /// </summary>
        public static void PrintEnterString()
        {
            Console.WriteLine(">>> Добавьте новую запись в формате 'Номер телефона : ФИО' ");
        }

        /// <summary>
        /// Возвращает  строку введенную пользователем
        /// </summary>
        /// <returns></returns>
        public static string GetEnteredString()
        {
            string result = string.Empty;
            Console.WriteLine("Введите номер телефона для поиска: ");
            result = Console.ReadLine();
            return result;
        }

    }
}
