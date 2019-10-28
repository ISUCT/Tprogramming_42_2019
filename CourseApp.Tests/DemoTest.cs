using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(4.1, 2.7, 2.8, 20)]
        [InlineData(4.1, 2.7, 3.6, 13)]
        public void TestEquat(double a, double b, double x, double exp)
        {
            int res = (int)Math.Floor(Program.Equat(a, b, x));
            Assert.Equal(res, exp);
        }

        [Theory]
        [InlineData(4.1, 2.7, 5.2, 5.1, 0.8)]
        public void TestTaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            Assert.Equal(res, new double[0]);

            // Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(4.1, 2.7)]
        public void TestTaskB(double a, double b)
        {
            double[] e = new double[0];
            var res = Program.TaskB(a, b, e);
            Assert.Equal(res, new double[0]);
        }

        [Theory]
        [InlineData(4.1, 2.7)]
        public void TestTaskBWork(double a, double b)
        {
            double[] mass = new double[5] { 1.9, 2.15, 2.34, 2.73, 3.16 };
            var res = Program.TaskB(a, b, mass);
            int[] resMass = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                resMass[i] = (int)Math.Floor(res[i]);
            }

            int[] exp = new int[5] { -100, 77, 38, 21, 16 };
            Assert.Equal(resMass, exp);
        }
    }
}
