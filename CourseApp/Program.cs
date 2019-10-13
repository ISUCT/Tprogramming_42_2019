using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Program
    {
        public static double FuncthionZnach(double x)
        {
            double result = Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 0.25) + Math.Pow(Math.Log10(Math.Pow(x, 2)), 0.33);
            return result;
        }

        public static double[] FuncthionForShag(double x_natch, double x_konch, double x_shag)
        {
            var result = new double[(int)((x_konch - x_natch) / x_shag) + 1];
            int kolch = 0;
            for (double i = x_natch; i <= x_konch; i += x_shag)
            {
                result[kolch] = FuncthionZnach(i);
                kolch++;
            }

            return result;
        }

        public static double[] FuncthionForMass(double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = FuncthionZnach(x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Задание A:");
            foreach (double element in FuncthionForShag(1.25, 3.25, 0.4))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"\nЗадание B:");
            var x = new double[] { 1.84, 2.71, 3.81, 4.56, 5.62 };
            foreach (var element in FuncthionForMass(x))
            {
                Console.WriteLine($"y = {element}");
            }

            Console.ReadLine();
        }
    }
}
