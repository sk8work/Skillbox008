using System;
using System.Collections.Generic;
using System.Text;

namespace HW004
{
    internal class Controller
    {
        public void Run()
        {
            bool start = true;
            do
            {
                ConsoleMethods.PrintMenu();
                char select;
                select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        Note note = new Note();

                        ConsoleMethods.EnterFio();
                        note.FIO = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterStreet();
                        note.Street = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterHomeNumberr();
                        note.HomeNumber = Convert.ToInt32(ConsoleMethods.GetEnteredString());

                        ConsoleMethods.EnterFlatNumber();
                        note.FlatNumber = Convert.ToInt32(ConsoleMethods.GetEnteredString());

                        ConsoleMethods.EnterMobilePhoneNumber();
                        note.MobilePhone = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterFlatPhoneNumber();
                        note.FlatPhone = ConsoleMethods.GetEnteredString();
                        break;
                    case '2':
                        break;
                    case '3':
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
