using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Точка A= ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Точка B= ");
            double B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                B = B + A; A = B - A; B = B - A;
            }
            Console.Write("Шаг H= ");
            double h = double.Parse(Console.ReadLine());
            h = Math.Abs(h);
            double X = A;
            while (X <= B)
            {
                double f = X * Math.Cos(1 / X) + 2;
                Console.WriteLine("X={0}    f={0}", X, f);
            }
            DirectoryInfo di1 = new DirectoryInfo(@"C:\Users\.txt");
            try
            {
                di1.Create();
            }
            catch (Exception)
            {
            }
            Console.WriteLine("----------------------------------------------");
            BookContainer bookContainer = new BookContainer();
            bookContainer.AddBook(new Book("1","1","1"));
            bookContainer.AddBook(new Book("2", "2", "2"));
            bookContainer.AddBook(new Book("3", "3", "3"));
            string name = bookContainer[1].GetName();
            int i = BookContainer.CompareByName(bookContainer[0], bookContainer[1]);
            bookContainer.Sort(BookContainer.CompareByPublishingHouse,BookContainer.Order.Descending);
            Console.WriteLine("Sorted books");
            Console.WriteLine($"Book-{"1"}");
            Console.WriteLine($"Book-{"2"}");
            Console.WriteLine($"Book-{"3"}");
        }
    }
}

