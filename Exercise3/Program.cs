using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // введення вихідних даних
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            // реалізація алгоритму розв'язання задачі
            double s = 0.5*c*h;
            // вивід результату
            Console.WriteLine("s={0}", s);
            Console.ReadKey();
        }
    }
}
