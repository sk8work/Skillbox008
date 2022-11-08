using System;
using System.Collections.Generic;
using System.Text;

namespace HW002
{
    class Start
    {
        
        public void Run()
        {
            NoteBook notebook = new NoteBook();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            bool start = true;
            do
            {
                ConsoleMethods.PrintMenu();
                char select;
                select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        notebook.NoteToDictionary(dictionary);
                        break;
                    case '2':
                        notebook.PrintDictionary(dictionary);
                        break;
                    case '3':
                        notebook.Getowner(dictionary);
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
