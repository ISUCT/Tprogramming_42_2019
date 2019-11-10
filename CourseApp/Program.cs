﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double Matem(double b, double x)
        {
            var y = (1 + Math.Pow(Math.Sin(Math.Pow(b, 5) + Math.Pow(x, 5)), 2)) / Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 0.33);
            return y;
        }

        public static double[] TaskA(double b, double xn, double xk, double dx)
        {
            int i = 0;
            double k = Math.Round((xk - xn) / dx);
            var y = new double[(int)k];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = Matem(b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = Matem(b, x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            double xn = 1.280;
            double xk = 3.280;
            double dx = 0.4;
            double b = 2.5;
            Console.WriteLine("Задание А:");
            foreach (var item in TaskA(b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            var x = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var taskBRes = TaskB(b, x);
            Console.WriteLine("Задание B:");
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y = {item}");
            }
        }
    }
}
