

namespace Rextester
{
    public class Program
    {
        public static void Problem(double a, double b, double x_begin, double x_end, double x_delta)
        {
            double yA;
            for (double x = x_begin; x < x_end; x = (x + x_delta))
            {
                yA = ((Math.Pow(a, x) - Math.Pow(b, x)) * (Math.Pow(a, (1 / 3)) * (Math.Pow(b, (1 / 3))))) /(Math.Log10(a/b));
                Console.WriteLine(yA + " ");
            }
        }
        public static void Arr(double a, double b)
        {
            double yB;
            double[] arr = { 4.48, 3.56, 2.78, 5.28,3.21 };
            for (int i = 0; i < 5; i++)
            {
                yB = ((Math.Pow(a, arr[i]) - Math.Pow(b, arr[i])) * (Math.Pow(a, (1 / 3)) * (Math.Pow(b, (1 / 3))))) / (Math.Log10(a / b));
                Console.WriteLine(yB + " ");
            }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("A ");
            Rextester.Program.Problem(0.4, 0.8, 3.2, 6.2, 0.6);
            Console.WriteLine("B ");
            Rextester.Program.Arr(0.4, 0.8);

        }
    }
}
