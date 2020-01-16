using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Math1
    {
        public static double MyFunction(double a, double b, double x)
        {
            return Math.Log10(Math.Pow(x, 2) - 1) / Math.Log(a * Math.Pow(x, 2)) / Math.Log(5);
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
            const double xn = 1.2;
            const double xk = 2.2;
            const double dx = 0.2;
            const double a = 1.1;
            const double b = 0.09;
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
