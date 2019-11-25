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
        [InlineData(0.7, 0.7, 5, 2.85745641603801)]
        [InlineData(1, 0.7, 5, 2.78360690322881)]
        public void TestMyFunction(double a, double b, double x, double exp)
        {
            Assert.Equal(Program.MyFunction(a, b, x), exp, 3);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Assert.Equal(double.NaN, res);
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
            List<double> x = new List<double> { 1.88, 2.26, 3.84, 4.55, -6.21 };
            List<double> res = Program.TaskB(0.8, 0.4, x);
            List<double> expy = new List<double> { 2.05703837959061, 2.16686308069159, 2.57116265691716, 2.72248916007313, 3.38484435329608 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
