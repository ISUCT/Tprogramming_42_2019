using System;
using System.Collections.Generic;
using System.Collections;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b,  double x)
        {
            var y = Math.Asin(Math.Pow(x, a)) + Math.Acos(Math.Pow(x, b));
            return y;
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            List<double> y = new List<double>();
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
            const double a = 2.0;
            const double b = 3.0;
            const double xn = 0.11;
            const double xk = 0.36;
            const double dx = 0.05;
            double count = xn;
            Console.WriteLine("Task A:");
            foreach (var i in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"x = {count += dx}, y = {i}");
            }

            Console.WriteLine();
            List<double> x = new List<double> { 0.08, 0.26, 0.35, 0.41, 0.53 };
            count = 0;
            Console.WriteLine("Task B:");
            foreach (var i in TaskB(a, b, x))
            {
                Console.WriteLine($"x = {x[(int)count++]}, y = {i}");
            }

            Console.ReadKey();
        }
    }
}