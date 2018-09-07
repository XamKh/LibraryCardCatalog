using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCardCatalog
{
    [Serializable()]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        //public int ID { get; set; }
        public int Year { get; set; }


        public override string ToString()
        {
            return $"The Title is: {Title}, Author is: {Author}, Year is: {Year}";
        }
    }
}
