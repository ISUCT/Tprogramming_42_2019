using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PlaneTests
    {
        [Theory]
        [InlineData(1000, 5000, "Boeing 737")]
        [InlineData(230, 1300, "Cessna 172")]
        public void TestConstructorThreeParametrs(int speed, int high, string model)
        {
            var item = new Plane(speed, high, model);
            Assert.Equal(speed, item.Speed);
            Assert.Equal(high, item.High);
            Assert.Equal(model, item.Model);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Plane(835, 4268);
            Assert.Equal(835, item.Speed);
            Assert.Equal(4268, item.High);
            Assert.Equal(" ", item.Model);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Plane(835);
            Assert.Equal(835, item.Speed);
            Assert.Equal(1000, item.High);
            Assert.Equal(" ", item.Model);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Plane();
            Assert.Equal(1000, item.Speed);
            Assert.Equal(1000, item.High);
            Assert.Equal(" ", item.Model);
        }

        [Fact]
        public void TestSetModel()
        {
            var item = new Plane();
            item.Model = "Boeing 737";
            Assert.Equal("Boeing 737", item.Model);
        }

        [Fact]
        public void TestIncorrectSetSpeed()
        {
            try
            {
                var item = new Plane();
                item.Speed = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetSpeed()
        {
            var item = new Plane();
            try
            {
                item.Speed = 1300;
                item.Speed = -500;
            }
            catch (System.Exception)
            {
                Console.WriteLine("CountSalo should be > 0");
                Assert.True(true);
            }

            Assert.Equal(1300, item.Speed);
        }
    }
}