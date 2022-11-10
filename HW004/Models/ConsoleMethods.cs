using System;
using System.Collections.Generic;
using System.Text;

namespace HW004
{
    internal class ConsoleMethods
    {
        /// <summary>
        /// Печатает заголовок программы
        /// </summary>
        public static void PrintHeader()
        {
            Console.WriteLine("Записная книжка. Теперь ваши контакты будут всегда под рукой!");
            Console.WriteLine("Да здравствует технический прогресс!");
        }

        /// <summary>
        /// Печатает меню
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("1 - Добавить запись ");
            Console.WriteLine("q - Выйти из программы ");
        }

        /// <summary>
        /// Возвращает  строку введенную пользователем
        /// </summary>
        /// <returns></returns>
        public static string GetEnteredString()
        {
            string result = string.Empty;
            result = Console.ReadLine();
            return result;
        }

        /// <summary>
        /// Введите ФИО
        /// </summary>
        public static void EnterFio()
        {
            Console.WriteLine("Введите ФИО");
        }

        /// <summary>
        /// Введите Улицу
        /// </summary>
        public static void EnterStreet()
        {
            Console.WriteLine("Введите Улицу");
        }

        /// <summary>
        /// Введите Номер дома
        /// </summary>
        public static void EnterHomeNumberr()
        {
            Console.WriteLine("Введите Номер дома");
        }

        /// <summary>
        /// Введите Номер квартиры
        /// </summary>
        public static void EnterFlatNumber()
        {
            Console.WriteLine("Введите Номер квартиры");
        }

        /// <summary>
        /// Введите Номер мобильного телефона
        /// </summary>
        public static void EnterMobilePhoneNumber()
        {
            Console.WriteLine("Введите Номер мобильного телефона");
        }

        /// <summary>
        /// Введите Номер домашнего телефона
        /// </summary>
        public static void EnterFlatPhoneNumber()
        {
            Console.WriteLine("Введите Номер домашнего телефона");
        }
    }
}
