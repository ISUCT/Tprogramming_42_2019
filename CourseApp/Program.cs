using System;

namespace CourseApp
{
    public class Program
    {
        public static void Equat(double a, double b, double x)
        {
            Console.WriteLine($"Для а={a}, b={b} и х={x}: " + (((a * Math.Sqrt(x)) - (b * Math.Log(x, 5))) / Math.Log10(Math.Abs(x - 1))));
        }

        public static void Main(string[] args)
        {
            double a = 4.1;
            double b = 2.7;
            Equat(a, b, 1.9);
            Equat(a, b, 2.15);
            Equat(a, b, 2.34);
            Equat(a, b, 2.73);
            Equat(a, b, 3.16);
            for (double x = 1.2; x < 5.21; x += 0.8)
            {
                Equat(a, b, x);
            }
        }
    }
}
