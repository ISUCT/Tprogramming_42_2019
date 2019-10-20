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

        [Fact]
        public void TestSummPositive()
        {
            var res = Program.Summ(2, 3);
            Assert.Equal(5, res);
        }

        [Fact]
        public void TestSummPositiveNegative()
        {
            var actualRes = Program.Summ(-2, 2);
            Assert.Equal(0, actualRes);
        }
    }
}
