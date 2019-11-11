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
            var item = new Car();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Car();
            item.Age = 10;
            item.Age = -5;
            Assert.Equal(10, item.Age);
        }
    }
}
