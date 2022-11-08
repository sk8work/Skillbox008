using System;
using System.Collections.Generic;

namespace HW001
{
    public class Start
    {
        /// <summary>
        /// Main Controller
        /// </summary>
        public void Run()
        {
            Numbers numbers = new Numbers();
            List<int> nums = new List<int>();
            bool start = true;
            do
            {
                ConsoleMethods.PrintMenu();
                char select = ' ';
                select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        numbers.Get100NumbersList(nums);
                        break;
                    case '2':
                        numbers.PrintList(nums);
                        break;
                    case '3':
                        int from = 25;
                        int to = 50;
                        numbers.DeleteFromList(nums, from, to);
                        Console.WriteLine($"Удалили числа от {from} до {to}");
                        break;
                    case '4':
                        from = numbers.GetNumber();
                        to = numbers.GetNumber();
                        numbers.DeleteFromList(nums, from, to);
                        Console.WriteLine($"Удалили числа от {from} до {to}");
                        break; 
                    case 'q':
                        start = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Сделайте выбор из пунктов меню");
                        break;
                }
            } while (start);

        }
    }
}