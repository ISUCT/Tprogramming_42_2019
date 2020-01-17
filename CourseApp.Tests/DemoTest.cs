using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(1, 1, 0, -2)]
        public void TestMyFunction(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.MyFunction(a, b, x), exp, 3);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            List<double> mass = new List<double>();
            var res = Program.TaskB(1, 2, mass);
            Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 0.15, 0.26, 0.37, 0.48, 0.56 };
            List<double> res = Program.TaskB(0.05, 0.06, x);
            List<double> expy = new List<double> { 77.5895864997276, 23.1288326051879, 10.6603389095227, 5.83682718123348, 3.96902894643885 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}