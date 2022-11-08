//Что нужно сделать
//Создайте лист целых чисел. 
//Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
//Выведите коллекцию чисел на экран. 
//Удалите из листа числа, которые больше 25, но меньше 50. 
//Снова выведите числа на экран.

using System;

namespace HW001
{
    class Program
    {
        /// <summary>
        /// Delay
        /// </summary>
        static void Delay()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ConsoleMethods.PrintHeader();

            Start s = new Start();

            s.Run();

            Delay();
        }
    }
}
