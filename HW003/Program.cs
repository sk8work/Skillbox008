//Пользователь вводит число. Число сохраняется в HashSet коллекцию. 
//Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение,
//что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, что число успешно сохранено. 

using System;

namespace HW003
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

            Controller controller = new Controller();

            controller.Run();

            Delay();
        }
    }
}
