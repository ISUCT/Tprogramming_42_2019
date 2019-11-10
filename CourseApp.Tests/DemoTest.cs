using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.0, 5.2, 4.2, 0.6)]
        public void TestTaskA(double a, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, xn, xk, dx);
            Assert.Equal(res, new double[5]);
        }

        [Theory]
        [InlineData(2.0)]
        public void TestTaskB(double a)
        {
            double[] e = new double[0];
            var res = Program.TaskB(a, e);
            Assert.Equal(res, new double[0]);
        }

        [Theory]
        [InlineData(2.0)]
        public void IsTaskBWork(double a)
        {
            var arr = new double[5] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var resB = Program.TaskB(a, arr);
            var result = new int[arr.Length];
            int j = 0;

            foreach (var item in resB)
            {
                result[j] = (int)Math.Floor(resB[j] * 1000);
                j++;
            }

            var exp = new int[] {25, 24, 24, 23, 22};
            Assert.Equal(result, exp);
        }

        [Theory]
        [InlineData(2.0, 1.2, 4.2, 0.6)]
        public void IsTaskAWork(double a, double xn, double xk, double dx)
        {
            var resA = Program.TaskA(a, xn, xk, dx);
            var result = new int[resA.Length];
            int j = 0;

            foreach (var item in resA)
            {
                result[j] = (int)Math.Floor(resA[j] * 1000);
                j++;
            }
                
            var exp = new int[] {24, 23, 21, 19, 17};
            Assert.Equal(result, exp);
        }
    }
}
