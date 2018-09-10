using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LibraryCardCatalog
{
    public class CardCatalog
    {
        private string _fileName;


        private List<Book> books;

        public CardCatalog(string fileName)
        {
            _fileName = fileName;
            string folderName = @"C:\UserData";
            Directory.CreateDirectory(folderName);
            string pathFile = Path.Combine(@"C:\UserData", this._fileName);
            


            Console.ForegroundColor = ConsoleColor.Cyan;
            if (File.Exists(@"C:\UserData\" + this._fileName))
            {
                var stream = File.Open(@"C:\UserData\" + this._fileName, FileMode.Open);

                BinaryFormatter bf = new BinaryFormatter();

                books = (List<Book>)bf.Deserialize(stream);

                stream.Close();
            }
            else
            {
                books = new List<Book>();
            }
        }

        public void Save()
        {

            Stream stream = File.Open(@"C:\UserData\" + this._fileName, FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, books);
            stream.Close();
        }

        public void AddBook()
        {
            string title = "";
            string author = "";
            int year = 0;
            Console.Clear();
            Console.Write("Please input the Title of the book: ");
            title = Console.ReadLine();

            Console.Write("\n");

            Console.Write("Please input the Author of the book: ");
            author = Console.ReadLine();

            Console.Write("\n");

            while (true)
            {
                Console.Write("Please input the year the book was published: ");
                if (int.TryParse(Console.ReadLine(), out year)) break;


            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            books.Add(new Book { Title = title, Author = author, Year = year });
           
        }

        public void ListBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }
        }
        
    }
}
