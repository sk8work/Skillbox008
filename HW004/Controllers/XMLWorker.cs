using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        public static List<Note> DeserializeList(string path)
        {
            List<Note> tempNoteCol = new List<Note>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));

            Stream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);

            tempNoteCol = xmlSerializer.Deserialize(fstream) as List<Note>;

            return tempNoteCol;
        }
    }
}
