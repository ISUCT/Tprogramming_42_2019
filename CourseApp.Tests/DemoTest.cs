using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(1, 2, 2, NaN)]
        [InlineData(1, 2, 5, 2.936)]
        public void TestEquat(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.Equat(a, b, x), exp, 3);
        }

        [Fact]
        public void TestTaskAempty()
        {
            var res = Program.TaskA(0.8, 0.4, 1.23, 0.23, 1.2);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.8, 0.4, 1.23, 7.23, 6).Count;
            Assert.Equal(2, res);
        }

        [Fact]
        public void TestTaskA2()
        {
            var res = Program.TaskA(0.8, 0.4, 1.23, 7.23, 6).Count;
            Assert.Equal(1, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> e = new List<double>();
            var res = Program.TaskB(0.8, 0.4, e);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestTaskBWork()
        {
            List<double> arr = new List<double>() { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var res = Program.TaskB(0.8, 0.4, arr).Count;
            Assert.Equal(5, res);
        }
    }
}