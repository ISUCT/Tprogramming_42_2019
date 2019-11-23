using System;

namespace CourseApp
{
    public class Program
    {
        public static double Equat(double a, double b, double x)
        {
            return ((a * Math.Sqrt(x)) - (b * Math.Log(x, 5))) / Math.Log10(Math.Abs(x - 1));
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk < xn)
            {
                return new double[0];
            }
            else
            {
                int size = (int)Math.Floor((xk - xn) / dx);
                double[] rtrn = new double[size + 1];
                size = 0;
                for (double x = xn; x < (xk + 0.1); x += dx)
                {
                    rtrn[size] = Equat(a, b, x);
                    size++;
                }

                return rtrn;
            }
        }

        public static double[] TaskB(double a, double b, double[] xm)
        {
            double[] rtrn = new double[xm.Length];
            for (int i = 0; i < xm.Length; i++)
            {
                rtrn[i] = Equat(a, b, xm[i]);
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            double a = 4.1;
            double b = 2.7;
            double[] mass = TaskA(a, b, 1.2, 5.2, 0.8);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            double[] mass2 = new double[5] { 1.9, 2.15, 2.34, 2.73, 3.16 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Adin = {(1 < 2 ? "1" : "0")}");
            Console.ReadKey();
        }
    }
}
