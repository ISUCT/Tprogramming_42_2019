using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b, double x)
        {
            var y = (1 + Math.Pow(Math.Log10(x / a), 2)) / (b - Math.Exp(x / a));
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
            const double a = 2.0;
            const double b = 0.95;
            const double xn = 1.25;
            const double xk = 2.75;
            const double dx = 0.3;
            Console.WriteLine("Задание А:");
            foreach (var item in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.WriteLine("Задание B:");
            var x = new double[] { 2.2, 3.78, 4.51, 6.58, 1.2 };
            foreach (var item in TaskB(a, b, x))
            {
                Console.WriteLine($"y = {item}");
            }

            Console.ReadLine();
        }
    }
}
