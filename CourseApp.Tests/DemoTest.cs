using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.0, 0.95, 2.8, -1)]
        [InlineData(2.0, 0.95, 3.6, -1)]
        public void TestMyFunction(double a, double b, double x, double exp)
        {
            int res = (int)Math.Floor(Program.MyFunction(a, b, x));
            Assert.Equal(res, exp);
        }

        [Theory]
        [InlineData(2.0, 0.95, 5.2, 5.1, 0.8)]
        public void TestTaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            Assert.Equal(res, new double[0]);
        }

        [Theory]
        [InlineData(2.0, 0.95)]
        public void TestTaskB(double a, double b)
        {
            double[] e = new double[0];
            var res = Program.TaskB(a, b, e);
            Assert.Equal(res, new double[0]);
        }

        [Theory]
        [InlineData(2.0, 0.95)]
        public void TestTaskBWork(double a, double b)
        {
            double[] mass = new double[5] { 2.2, 3.78, 4.51, 6.58, 1.2 };
            var res = Program.TaskB(a, b, mass);
            double[] resMass = new double[mass.Length];

            for (int i = 0; i < mass.Length; i++)
            {
                resMass[i] = Math.Round(res[i], 3);
            }

            double[] exp = new double[5] { -0.488, -0.19, -0.131, -0.049, -1.203 };
            Assert.Equal(resMass, exp);
        }
    }
}
