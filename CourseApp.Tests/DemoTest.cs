using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0.1, 0.5, 0.15, 0)]
        [InlineData(0.1, 0.5, 1.15, 0.0069)]
        public void TestEquat(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.Equat(a, b, x), exp, 4);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.1, 0.5, 2.15, 1.37, 0.25);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskB()
        {
            double[] e = new double[0];
            var res = Program.TaskB(0.1, 0.5, e);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskBWork()
        {
            double[] mass = new double[5] { 0.2, 0.3, 0.44, 0.6, 0.56 };
            var res = Program.TaskB(0.1, 0.5, mass);
            int[] resMass = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                resMass[i] = (int)Math.Floor(res[i]);
            }

            int[] exp = new int[5] { 0, 0, 0, 0, 0 };
            Assert.Equal(resMass, exp);
        }
    }
}