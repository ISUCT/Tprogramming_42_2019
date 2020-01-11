using System;
using Xunit;
using System.Collections.Generic;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(2.0, 5.2, 4.2, 0.6)]
        public void TestTaskA(double a, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, xn, xk, dx);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskB()
        {
            double[] e = new double[0];
            var res = Program.TaskB(2.0, e);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void IsTaskBWork()
        {
            var arr = new double[5] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var resB = Program.TaskB(2.0, arr);
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
            List<double> result = new List<double>();
            int j = 0;

            foreach (var item in resA)
            {
                result.Add(Math.Round(resA[j], 3));
                j++;
            }
                
            var exp = new double[] { 0.025, 0.023, 0.021, 0.02, 0.018 };
            Assert.Equal(result.ToArray(), exp);
        }
    }
}
