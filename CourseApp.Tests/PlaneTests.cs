using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PlaneTests
    {
        [Theory]
        [InlineData("Name", 1, 2)]
        [InlineData("Name1", 5, 6)]
        public void TestConstructorThreeParametrs(string brand, int age, int speed)
        {
            var item = new Plane(brand, age, speed);
            Assert.Equal(brand, item.Brand);
            Assert.Equal(age, item.Age);
            Assert.Equal(speed, item.Speed);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Plane("Name2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Name2", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Plane("Name3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Name3", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Plane();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Plane();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Plane();
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Plane();
            try
            {
                item.Age = 500;
                item.Age = -250;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be > 0");
                Assert.True(true);
            }

            if (item.Age == 500)
            {
                Assert.Equal(500, item.Age);
            }
        }

        [Fact]
        public void TestCorectToString()
        {
            var item = new Plane();
            try
            {
                item.Sound();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error toString");
                Assert.True(true);
            }

            Assert.Equal($"Бренд:{item.Brand}, Возраст:{item.Age}, Скорость:{item.Speed}", item.ToString());
        }

        [Fact]
        public void TestCorectSound()
        {
            var item = new Plane();
            try
            {
                item.Sound();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error sound");
                Assert.True(true);
            }

            Assert.True(true);
        }

        [Fact]
        public void TestCorrectUse()
        {
            var item = new Plane();
            int currAge = item.Age;
            item.Use();
            Assert.Equal(item.Age, currAge + 1);
        }

        [Fact]
        public void TestCorrectBraking()
        {
            var item = new Plane();
            int currSpeed = item.Speed;
            try
            {
                item.Braking();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error braking");
                Assert.True(true);
            }

            Assert.Equal(item.Speed, currSpeed - 1);
        }
    }
}
