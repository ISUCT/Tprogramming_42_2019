using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(4.1, 2.7, 2.8, 20.109)]
        [InlineData(4.1, 2.7, 3.6, 13.568)]
        public void TestEquat(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.Equat(a, b, x), exp, 3);
        }

        [Fact]
        public void TestTaskAempty()
        {
            var res = Program.TaskA(4.1, 2.7, 5.2, 5.1, 0.8);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(4.1, 2.7, 5.0, 5.9, 0.8).Length;
            Assert.Equal(2, res);
        }

        [Fact]
        public void TestTaskA2()
        {
            var res = Program.TaskA(4.1, 2.7, 5.0, 5.1, 6.0).Length;
            Assert.Equal(1, res);
        }

        [Fact]
        public void TestTaskB()
        {
            double[] e = new double[0];
            var res = Program.TaskB(4.1, 2.7, e);
            Assert.Equal(res, new double[0]);
        }

        [Fact]
        public void TestTaskBWork()
        {
            double[] mass = new double[5] { 1.9, 2.15, 2.34, 2.73, 3.16 };
            var res = Program.TaskB(4.1, 2.7, mass).Length;
            Assert.Equal(5, res);
        }
    }
}
