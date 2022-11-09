using System;
using System.Collections.Generic;
using System.Text;

namespace HW003
{
    internal class Controller
    {
        public void Run()
        {
            HashSet<int> hashSet = new HashSet<int>();
            bool start = true;
            do
            {
                ConsoleMethods.PrintMenu();
                char select;
                select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        Set.HashUnion(hashSet, ConsoleMethods.GetAddedParams());
                        break;
                    case '2':
                        Set.HashRemove(hashSet, ConsoleMethods.GetRemovedParams());
                        break;
                    case '3':
                        Set.PrintHashSet(hashSet);
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
