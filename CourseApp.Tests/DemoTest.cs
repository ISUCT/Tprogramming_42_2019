using System;
using Xunit;
using NUnit.Framework;

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
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(1, 2, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var res = Program.TaskB(0.8, 0.4, x);
            var expy = new double[] { 2.05703837959061, 2.16686308069159, 2.57116265691716, 2.72248916007313, 3.38484435329608 };
            for (int i = 0; i < 5; i++)
            {
                NUnit.Framework.Assert.AreEqual(expy[i], res[i], 0.00001);
            }
        }
    }
}
