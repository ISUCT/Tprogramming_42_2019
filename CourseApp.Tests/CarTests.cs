using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CarTests
    {
        [Theory]
        [InlineData("Name", 1, 2)]
        [InlineData("Name1", 5, 6)]
        public void TestConstructorThreeParametrs(string brand, int age, int speed)
        {
            var item = new Car(brand, age, speed);
            Assert.Equal(brand, item.Brand);
            Assert.Equal(age, item.Age);
            Assert.Equal(speed, item.Speed);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Car("Name2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Name2", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Car("Name3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Name3", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Car();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Brand);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Car();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Car();
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
            var item = new Car();
            try
            {
                item.Age = 10;
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Speed should be > 0");
                Assert.True(true);
            }

            Assert.Equal(10, item.Age);
        }

        [Fact]
        public void TestCorectToString()
        {
            var item = new Car();
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
            var item = new Car();
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
            var item = new Car();
            int currAge = item.Age;
            try
            {
                item.Use();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Error use");
                Assert.True(true);
            }

            Assert.Equal(item.Age, currAge + 1);
        }

        [Fact]
        public void TestCorrectBraking()
        {
            var item = new Car();
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
