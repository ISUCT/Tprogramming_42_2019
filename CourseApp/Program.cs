using System;
using System.Collections.Generic;
using System.Collections;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b,  double x)
        {
            var y = Math.Pow(a + (b * x), 2.5) / (1 + Math.Log10(a + (b * x)));
            return y;
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            List<double> y = new List<double>((int)((xk - xn) / dx));
            for (double x = xn; x < xk; x += dx)
            {
                y.Add(MyFunction(a, b, x));
            }

            return y;
        }

        public static List<double> TaskB(double a, double b, List<double> x)
        {
            List<double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(MyFunction(a, b,  x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 2.5;
            const double b = 4.6;
            const double xn = 1.1;
            const double xk = 3.6;
            const double dx = 0.5;
            double count = xn;
            Console.WriteLine("Task A:");
            foreach (var i in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"x = {count += dx}, y = {i}");
            }

            Console.WriteLine();
            List<double> x = new List<double> { 1.2, 1.28, 1.36, 1.46, 2.35 };
            count = 0;
            Console.WriteLine("Task B:");
            foreach (var i in TaskB(a, b, x))
            {
                Console.WriteLine($"x = {x[(int)count++]}, y = {i}");
            }

            Console.WriteLine();
            Ship[] array = new Ship[2];
            array[0] = new Cruiser("Sydney", 171.3, 6830);
            array[1] = new Corvette("Guarding", 104.5, 2220);

            for (int i = 0; i < 2; i++)
            {
                array[i].SayShip();
            }

            Console.ReadKey();
        }
    }
}