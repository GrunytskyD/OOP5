using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class BookContainer
    {
        public delegate int BookComparator(Book bookOne, Book bookTwo);
        public static int CompareByName(Book bookOne, Book bookTwo)
        {
            return bookOne.GetName().CompareTo(bookTwo.GetName());
        }
        public static void SwapBook(ref Book bookOne, ref Book bookTwo)
        {
            Book tmp = bookOne;
            bookOne = bookTwo;
            bookTwo = tmp;
        }
        public static int CompareByAuthor(Book bookOne, Book bookTwo)
        {
            return bookOne.GetAuthor().CompareTo(bookTwo.GetAuthor());
        }
        public static int CompareByPublishingHouse(Book bookOne, Book bookTwo)
        {
            return bookOne.GetPublishingHouse().CompareTo(bookTwo.GetPublishingHouse());
        }

        /*internal void Sort(Func<Book, Book, int> compareByPublishingHouse, object descending)
        {
            throw new NotImplementedException();
        }*/

        protected List<Book> Books;
        public enum Order { Ascending,Descending}

        /*public static object Order { get; internal set; }*/

        public BookContainer()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public Book this[int index]
        {
            get
            {
                return Books[index];
            }
        }
        public void Sort(BookComparator bookComparator, Order order = Order.Ascending)
        {
            /*if (bookComparator(Books[i], Books[j]) > 0)
                SwapBook(ref Books[i], ref Books[j]);*/
        }
    }
}
