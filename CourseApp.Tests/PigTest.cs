using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PigTest
    {
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