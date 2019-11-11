using System;
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
        [InlineData(1, 1.10668191970032)]
        [InlineData(2, 1.95250809998776)]
        public void TestFuncthionZnach(double x, double e)
        {
            Assert.Equal(e, Program.FuncthionZnach(x), 3);
        }

        [Fact]
        public void TestZeroFuncthionZnach()
        {
            var res = Program.FuncthionZnach(0.0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestNullMassFuncthionForMass()
        {
            var mass = new double[0];
            var res = Program.FuncthionForMass(mass);
            Assert.Equal(mass, res);
        }

        [Fact]
        public void TestFuncthionForShag()
        {
            var x = new double[] { 1.84, 2.71, 3.81, 4.56, 5.62 };
            var res = Program.FuncthionForMass(x);
            var expY = new double[] { 1.78088177902672, 2.43716358850851, 2.91258396550454, 3.16349459673976, 3.46531788233977 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expY[i], res[i], 3);
            }
        }
    }
}
