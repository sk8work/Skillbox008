using System;
using System.Collections.Generic;
using System.Text;

namespace HW002
{
    class NoteBook
    {        
        /// <summary>
        /// Возвращяет строку для добавления записи
        /// </summary>
        /// <returns></returns>
        public string InsertNote()
        {
            ConsoleMethods.PrintEnterString();
            string noteString = Console.ReadLine();
            return noteString;
        }

        /// <summary>
        /// Добавляет запись в Dictionary
        /// </summary>
        /// <param name="dictionary"></param>
        public void NoteToDictionary(Dictionary<string, string> dictionary)
        {
            bool addstring = true;
            while(addstring)
            {
                string note = InsertNote();

                if (note.Contains(":"))
                {
                    string[] addNote = note.Split(":");
                    if (!dictionary.ContainsKey(addNote[0].Trim()))
                    {
                        dictionary.Add(addNote[0].Trim(), addNote[1].Trim());
                    } else
                    {
                        Console.WriteLine("Такой номер уже зарегистрирован.");
                    }
                }
                else
                {
                    Console.WriteLine("Неферный формат ввода. Проверьте данные");
                    addstring = false;
                }
            }
        }

        /// <summary>
        /// Печатает элементы Dicyionary в консоль
        /// </summary>
        /// <param name="dictionary"></param>
        public void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        /// <summary>
        /// Получение пользователя по номеру телефона
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public void Getowner(Dictionary<string, string> dictionary)
        {
            string value = string.Empty;
            string number = ConsoleMethods.GetEnteredString();
            if (dictionary.TryGetValue(number, out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine($"Пользователя с телефоном {number} не найдено");
            }
        }
    }
}
