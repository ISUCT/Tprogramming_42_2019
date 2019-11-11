using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PigTest
    {
        [Theory]
        [InlineData("Name", 1, 10)]
        [InlineData("Name1", 3, 12320)]
        public void TestConstructorThreeParametrs(string name, int age, int countSalo)
        {
            var item = new Pig(name, age, countSalo);
            Assert.Equal(age, item.Age);
            Assert.Equal(name, item.Name);
            Assert.Equal(countSalo, item.CountSalo);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Pig("Name2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Name2", item.Name);
            Assert.Equal(0, item.CountSalo);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Pig("Name3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Name3", item.Name);
            Assert.Equal(0, item.CountSalo);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Pig();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Name);
            Assert.Equal(0, item.CountSalo);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Pig();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Pig();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Pig();
            item.Age = 10;
            item.Age = -5;
            Assert.Equal(10, item.Age);
        }
    }
}