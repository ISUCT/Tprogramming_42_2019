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
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0,0.0,0.0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            var mass = new double[0];
            var res = Program.TaskB(1,2,mass);
            Assert.Equal(mass,res);
        }
        [Fact]
        public void TestTaskB()
        {
            var x = new double[] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            var res = Program.TaskB(1,2,x);
            Assert.Equal(x,res);
        }
        
     

    }
}
