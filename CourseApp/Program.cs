using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = Math.Acos(Math.Pow(x, 2) - Math.Pow(b, 2)) / Math.Asin(Math.Pow(x, 2) - Math.Pow(a, 2));
            return y;
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            int i = 0;
            var y = new List<double>();
            for (double x = xn; x <= xk; x += dx)
            {
                y.Add(MyFunction(a, b, x));
                Console.WriteLine(i);
                i++;
            }

            return y;
        }

        public static List<double> TaskB(double a, double b, List<double> x)
        {
            List<double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(a, b, x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            double xn = 0.2;
            double xk = 0.95;
            double dx = 0.15;
            double b = 0.06;
            double a = 0.05;
            Console.WriteLine("Задание А:");
            foreach (var item in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            List<double> x = new List<double> { 0.15, 0.26, 0.37, 0.48, 0.56 };
            Console.WriteLine("Задание B:");
            foreach (var item in TaskB(a, b, x))
            {
                Console.WriteLine($"y = {item}");
            }
        }
    }
}