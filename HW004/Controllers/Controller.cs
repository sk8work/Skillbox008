using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HW004
{
    internal class Controller
    {
        public void Run()
        {
            Note note = new Note();
            bool start = true;
            do
            {
                ConsoleMethods.PrintMenu();
                char select;
                select = Convert.ToChar(Console.ReadLine());
                switch (select)
                {
                    case '1':
                        ConsoleMethods.EnterFio();
                        note.FIO = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterStreet();
                        note.Street = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterHomeNumberr();
                        note.HomeNumber = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterFlatNumber();
                        note.FlatNumber = Convert.ToInt32(ConsoleMethods.GetEnteredString());

                        ConsoleMethods.EnterMobilePhoneNumber();
                        note.MobilePhone = ConsoleMethods.GetEnteredString();

                        ConsoleMethods.EnterFlatPhoneNumber();
                        note.FlatPhone = ConsoleMethods.GetEnteredString();
                        string[] nameString = (note.FIO.ToString()).Split(" ");
                        string path = @$"_{nameString[0]}.xml";
                        XMLWorker.CreateXMLStruct(note, path);
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
