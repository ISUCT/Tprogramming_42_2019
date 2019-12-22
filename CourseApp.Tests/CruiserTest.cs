using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CruiserTest
    {
        [Theory]
        [InlineData("Cruiser", 124, 5810.79)]
        [InlineData("Cruiser", 227, 9500.4)]
        public void TestConstructorThreeParametrs(string name, float length, float displacement)
        {
            var item = new Cruiser(name, length, displacement);
            Assert.Equal(length, item.Length);
            Assert.Equal(name, item.Name);
            Assert.Equal(displacement, item.Displacement);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Cruiser("Cruiser", 124.68);
            Assert.Equal(124.68, item.Length);
            Assert.Equal("Cruiser", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Cruiser("Cruiser");
            Assert.Equal(1, item.Length);
            Assert.Equal("Cruiser", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Cruiser();
            Assert.Equal(1, item.Length);
            Assert.Equal("Unnamed Cruiser", item.Name);
            Assert.Equal(1, item.Displacement);
        }

        [Fact]
        public void TestSetLength()
        {
            var item = new Cruiser();
            item.Length = 124.98;
            Assert.Equal(124.98, item.Length);
        }

        [Fact]
        public void TestIncorrectSetLenght()
        {
            try
            {
                var item = new Cruiser();
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
            var item = new Cruiser();
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
            var item = new Cruiser();
            item.Displacement = 26640.98;
            Assert.Equal(26640.98, item.Displacement);
        }

        [Fact]
        public void TestIncorrectSetDisplacement()
        {
            try
            {
                var item = new Cruiser();
                item.Displacement = -54000;
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
            var item = new Cruiser();
            try
            {
                item.Displacement = 30000;
                item.Displacement = -500000;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Displacement should be > 0");
                Assert.True(true);
            }
        }
    }
}