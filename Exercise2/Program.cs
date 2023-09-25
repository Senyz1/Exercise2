using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // введення вихідних даних
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            // реалізація алгоритму розв'язання задачі
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            // вивід результату
            Console.WriteLine("s={0}", s);
            Console.ReadKey();
        }
    }
}
