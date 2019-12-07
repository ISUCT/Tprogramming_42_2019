using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DogTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var dog = new Dog();
            Assert.Equal(0, dog.Age);
            Assert.Equal("Untitled", dog.Name);
            Assert.True(dog.IsMale);
        }

        [Fact]
        public void TestConstructor()
        {
            var item = new Dog(12, "Nancy", false);
            Assert.Equal(12, item.Age);
            Assert.Equal("Nancy", item.Name);
            Assert.False(item.IsMale);
        }

        [Fact]
        public void TestBarking()
        {
            var item = new Dog();
            Assert.Equal("gav-gav", item.Barking());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Dog();
            item.Age = 7;
            Assert.Equal(7, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Dog();
            item.Age = 22;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Dog();
            item.Age = 8;
            item.Age = -15;
            Assert.Equal(8, item.Age);
        }
    }
}