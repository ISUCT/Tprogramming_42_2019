using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (Math.Pow(a, x) - Math.Pow(b, x)) * Math.Pow(a * b, 1.0 / 3) / Math.Log10(a / b);
            return y;
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk < xn)
            {
                return new List<double>();
            }
            else
            {
                List<double> rtrn = new List<double>();
                for (double x = xn; x < (xk + 0.1); x += dx)
                {
                    rtrn.Add(MyFunction(a, b, x));
                }

                return rtrn;
            }
        }

        public static List<double> TaskB(double a, double b, List<double> xm)
        {
            List<double> rtrn = new List<double>();
            foreach (double item in xm)
            {
                rtrn.Add(MyFunction(a, b, item));
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            const double xn = 3.2;
            const double xk = 6.2;
            const double dx = 0.6;
            const double a = 0.4;
            const double b = 0.8;
            List<double> mass = TaskA(a, b, xn, xk, dx);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            List<double> mass2 = new List<double>() { 4.48, 3.56, 2.78, 5.28, 3.21 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}