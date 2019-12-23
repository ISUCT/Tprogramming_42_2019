using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(1.0, 0.0, 0.0);
            Xunit.Assert.Equal(0, res);
        }

        [Theory]
        [InlineData(2.0, 3.0, 0.11, 0.36, 0.05)]
        public void TestElementsA(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            ArrayList list = new ArrayList() { a, b, xn, xk, dx };
            double massElemExpected = (xk - xn) / dx;
            Xunit.Assert.Equal(massElemExpected, list.Count);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            List<double> mass = new List<double>();
            var res = Program.TaskB(1, 2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 0.08, 0.26, 0.35, 0.41, 0.53 };
            var res = Program.TaskB(2.0, 3.0, x);
            var expy = new double[] { 1.576684370464, 1.62087101387868, 1.65071664516254, 1.67072256986309, 1.70609554498699 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}