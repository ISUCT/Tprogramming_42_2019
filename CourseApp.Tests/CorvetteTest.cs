using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CorvetteTest
    {
        [Theory]
        [InlineData("Corvette", 115, 900.79)]
        [InlineData("Corvette", 96, 1440.9)]
        public void TestConstructorThreeParametrs(string name, float length, float displacement)
        {
            var item = new Corvette(name, length, displacement);
            Assert.Equal(length, item.Length);
            Assert.Equal(name, item.Name);
            Assert.Equal(displacement, item.Displacement);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Corvette("Corvette", 114.68);
            Assert.Equal(114.68, item.Length);
            Assert.Equal("Corvette", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Corvette("Corvette");
            Assert.Equal(1, item.Length);
            Assert.Equal("Corvette", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Corvette();
            Assert.Equal(1, item.Length);
            Assert.Equal("Unnamed Corvette", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestSetLength()
        {
            var item = new Corvette();
            item.Length = 144.98;
            Assert.Equal(144.98, item.Length);
        }

        [Fact]
        public void TestIncorrectSetLenght()
        {
            try
            {
                var item = new Corvette();
                item.Length = -50;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Length should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetLength()
        {
            var item = new Corvette();
            try
            {
                item.Length = 100;
                item.Length = -50;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Length should be > 0");
                Assert.True(true);
            }

            Assert.Equal(100, item.Length);
        }

        [Fact]
        public void TestSetDisplacement()
        {
            var item = new Corvette();
            item.Displacement = 1440.98;
            Assert.Equal(1440.98, item.Displacement);
        }

        [Fact]
        public void TestIncorrectSetDisplacement()
        {
            try
            {
                var item = new Corvette();
                item.Displacement = -5000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Displacement should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetDisplacement()
        {
            var item = new Corvette();
            try
            {
                item.Displacement = 1000;
                item.Displacement = -5000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Displacement should be > 0");
                Assert.True(true);
            }
        }
    }
}