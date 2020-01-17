using System.Collections.Generic;
using System;

namespace CourseApp
{
    public class Program
    {
        public static double Equat(double a, double b, double x)
        {
            return (Math.Pow(Math.Pow(x - a, 2), 1.0 / 3.0) + Math.Pow(Math.Abs(x + b), 1.0 / 5.0)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a + b, 2), 1.0 / 9.0);
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            List<double> rtrn = new List<double>();
            for (double x = xn; x < (xk + 0.1); x += dx)
            {
                rtrn.Add(Equat(a, b, x));
            }

            return rtrn;
        }

        public static List<double> TaskB(double a, double b, List<double> xm)
        {
            List<double> rtrn = new List<double>();
            foreach (double item in xm)
            {
                rtrn.Add(Equat(a, b, item));
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            double a = 0.8;
            double b = 0.4;
            List<double> mass = TaskA(a, b, 1.23, 7.23, 1.2);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            List<double> mass2 = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");
            Console.WriteLine(Equat(1.0, 2.0, 5));

            Console.WriteLine("Enter name for your Sudno");
            string n;
            n = Console.ReadLine();
            Sudno[] sudno = new Sudno[2];
            sudno[1] = new Boat("Лодка");
            sudno[2] = new Ship("Корабль");

            foreach (var item in sudno)
            {
                
                item.SetDisplacement();
                item.SetLen();
                item.GoTo();
                item.Riffs();
            }

            Console.Read();
        }
    }
}