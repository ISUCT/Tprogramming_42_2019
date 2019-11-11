﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (Math.Pow(Math.Pow(x - a, 2), 0.33) + Math.Pow(Math.Abs(x + b), 0.2)) / Math.Pow((x * x) - Math.Pow(a + b, 2), 0.11);
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int i = 0;
            var y = new double[(int)((xk - xn) / dx)];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 0.8;
            const double b = 0.4;
            const double xn = 1.23;
            const double xk = 7.23;
            const double dx = 1.2;
            Console.WriteLine(MyFunction(1, 0.7, 5));
            Console.WriteLine("Задание А:");
            foreach (var item in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.WriteLine("Задание B:");
            var x = new double[] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            foreach (var item in TaskB(a, b, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}
