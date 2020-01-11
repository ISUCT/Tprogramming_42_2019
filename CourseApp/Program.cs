using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double[] TaskA(double a, double xn, double xk, double dx)
        {
            int j = 0;
            List<double> y = new List<double>();

            for (var i = xn; i < xk; i += dx)
            {
                y.Add(Math.Pow(Math.Log10(a + i), 2) / Math.Pow(a + i, 2));
                j++;
            }

            return y.ToArray();
        }

        public static double[] TaskB(double a, double[] x)
        {
            var y = new double[x.Length];

            for (var i = 0; i < y.Length; i++)
            {
                y[i] = Math.Pow(Math.Log10(a + x[i]), 2) / Math.Pow(a + x[i], 2);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double xn = 1.2;
            const double xk = 4.2;
            const double dx = 0.6;

            var resSingle = TaskA(a, xn, xk, dx);
            foreach (var item in resSingle)
            {
                Console.WriteLine($"y = {item}");
            }

            var x = new double[] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var taskBRes = TaskB(a, x);
            foreach (var item in taskBRes)
            {
                Console.WriteLine($"y1 = {item}");
            }

            Animal[] array = new Animal[2];
            array[0] = new Mouse(2, "Rat", true);
            array[1] = new Dog(2, "Pyos Dog", true);

            for (int i = 0; i < 2; i++)
            {
                array[i].SayAnything();
            }

            Console.ReadLine();
        }
    }
}
