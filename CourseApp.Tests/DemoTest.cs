using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0.4, 0.8, 2.8, 1.042)]
        [InlineData(0.4, 0.8, 3.6, 0.934)]
        public void TestMyFunction(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.MyFunction(a, b, x), exp, 3);
        }

        [Fact]
        public void TestTaskAempty()
        {
            var res = Program.TaskA(0.4, 0.8, 4.4, 4.2, 0.6);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestTaskA3()
        {
            var res = Program.TaskA(0.4, 0.8, 5.4, 5.2, 0.8).Count;
            Assert.Equal(0, res);
        }

        [Fact]
        public void TestTaskA()
        {
            var res = Program.TaskA(0.4, 0.8, 4.4, 5.2, 0.8).Count;
            Assert.Equal(2, res);
        }

        [Fact]
        public void TestTaskA2()
        {
            var res = Program.TaskA(0.4, 0.8, 4.0, 4.1, 3.0).Count;
            Assert.Equal(1, res);
        }

        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> e = new List<double>();
            var res = Program.TaskB(0.4, 0.8, e);
            Assert.Equal(res, new List<double>());
        }

        [Fact]
        public void TestTaskBWork()
        {
            List<double> mass = new List<double>() { 3.2, 3.8, 4.4, 5.0, 5.6, 6.2 };
            var res = Program.TaskB(0.4, 0.8, mass).Count;
            Assert.Equal(6, res);
        }
    }
}