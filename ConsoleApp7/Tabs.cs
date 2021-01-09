using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Tabs
    {
        protected string DirInfo;
        /*public Tabs(string dirInfo)
        {
            DirInfo = dirInfo;
        }*/
        public Tabs(DirectoryInfo di)
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
                Console.WriteLine("X={0}   f={0}", X, f);
            }
            DirectoryInfo di1 = new DirectoryInfo(@"C:\Users\.txt");
            try
            {
                di1.Create();
            }
            catch (Exception)
            {
            }
        }
    }
}
    
    

