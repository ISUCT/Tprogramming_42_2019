using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0.7, 5, 0.290669706554148)]
        [InlineData(1, 5, 0.2053945770368)]
        public void TestMyFunction(double b, double x, double exp)
        {
            Assert.Equal(Program.Matem(b, x), exp, 3);
        }

        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.Matem(0.0, 0.0);
            Xunit.Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            List<double> mass = new List<double>();
            var res = Program.TaskB(2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double>() { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var res = Program.TaskB(2.5, x);
            var expy = new List<double> { 0.750082078454372, 0.639743913195054, 0.504058298008105, 0.699366948598495, 0.381615534970301 };
            for (int i = 0; i < res.Count; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}