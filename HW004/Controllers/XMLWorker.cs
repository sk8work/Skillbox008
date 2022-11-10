using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HW004
{
    class XMLWorker
    {
        /// <summary>
        /// Метод сериализации
        /// </summary>
        /// <param name="n"></param>
        /// <param name="path"></param>
        public static void SerializeXML(Note n, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Note));

            Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fstream, n);

            fstream.Close();
        }

        /// <summary>
        /// Метод десериализации
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Note Deserialize(string path)
        {
            Note tempNote = new Note();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Note));

            Stream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);

            tempNote = xmlSerializer.Deserialize(fstream) as Note;

            fstream.Close();

            return tempNote;
        }

        /// <summary>
        /// Метод сериализации списка List<T>
        /// </summary>
        /// <param name="n"></param>
        /// <param name="path"></param>
        public static void SerializeList(List<Note> n, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));

            Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write);

            xmlSerializer.Serialize(fstream, n);

            fstream.Close();
            
        }

        /// <summary>
        /// Метод десериализации списка List<T>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Note> DeserializeList(string path)
        {
            List<Note> tempNoteCol = new List<Note>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));

            Stream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);

            tempNoteCol = xmlSerializer.Deserialize(fstream) as List<Note>;

            return tempNoteCol;
        }

        /// <summary>
        /// Сериализация XML
        /// </summary>
        /// <param name="n"></param>
        /// <param name="path"></param>
        public static void CreateXMLStruct(Note n, string path)
        {
            XElement newPerson      = new XElement("Person");
            XElement newAddress     = new XElement("Address");
            XElement newStreet      = new XElement("Street");
            XElement newHouseNumber = new XElement("HouseNumber");
            XElement newFlatNumber  = new XElement("FlatNumber");
            XElement newPhones      = new XElement("Phones");
            XElement newMobilePhone = new XElement("MobilePhone");
            XElement newFlatPhone   = new XElement("FlatPhone");

            XAttribute xAttributeName = new XAttribute("name", n.FIO);

            newPerson.Add(xAttributeName);
            newPerson.Add(newAddress, newPhones);
            newAddress.Add(newStreet, newHouseNumber, newFlatNumber);
            newStreet.Add(n.Street);
            newHouseNumber.Add(n.HomeNumber);
            newFlatNumber.Add(n.FlatNumber);
            newPhones.Add(newMobilePhone, newFlatPhone);
            newMobilePhone.Add(n.MobilePhone);
            newFlatPhone.Add(n.FlatPhone);
            newPerson.Save(path);
        }
    }
}
