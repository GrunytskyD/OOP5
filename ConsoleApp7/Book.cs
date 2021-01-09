using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Book
    {
        protected string Name;
        protected string Author;
        protected string PublishingHouse;

        public int CompareByName(Book bookoOne, Book bookTwo)
        {
            return bookoOne.Name.CompareTo(bookTwo.Name);
        }
        public Book(string name, string author, string publishingHouse)
        {
            Name = name;
            Author = author;
            PublishingHouse = publishingHouse;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public string GetPublishingHouse()
        {
            return PublishingHouse;
        }
    }
}
