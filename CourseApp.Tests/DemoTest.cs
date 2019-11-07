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
        public void TestZeroFuncthionZnach()
        {
            var res = Program.FuncthionZnach(0.0);
            Xunit.Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestNullMassFuncthionForMass()
        {
            var mass = new double[0];
            var res = Program.FuncthionForMass(mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestFuncthionForShag()
        {
            var x = new double[] { 1.84, 2.71, 3.81, 4.56, 5.62 };
            var res = Program.FuncthionForMass(x);
            var expY = new double[] { 1.78088177902672, 2.43716358850851, 2.91258396550454, 3.16349459673976, 3.46531788233977 };
            for (int i = 0; i < 5; i++)
            {
                NUnit.Framework.Assert.AreEqual(expY[i], res[i], 0.0001);
            }
        }
    }
}
