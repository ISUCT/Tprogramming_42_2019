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
            var res = Program.MyFunction(0.0, 0.0, 0.0);
            Xunit.Assert.Equal(0, res);
        }

        [Theory]
        [InlineData(2.5, 4.6, 1.1, 3.6, 0.5)]
        public void TestElementsA(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            ArrayList list = new ArrayList() { a, b, xn, xk, dx };
            double massElemExpected = (xk - xn) / dx;
            Xunit.Assert.Equal(massElemExpected, list.Count);
        }

        [Theory]
        [InlineData(2.5, 4.6, 1.1, 3.6, 0.5)]
        public void TestTaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = Program.TaskA(a, b, xn, xk, dx);
            List<double> mass = new List<double> { 83.654296330167824, 153.10661053388407, 247.3100209518459, 368.07230864815369, 517.00738615331488 };
            Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            List<double> mass = new List<double>();
            var res = Program.TaskB(1.2, 1.28, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var res = Program.TaskB(2.5, 4.6, x);
            var expy = new double[] { 95.6597421284176, 105.929786335064, 116.801060432846, 131.24861950568, 304.266557438152 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
