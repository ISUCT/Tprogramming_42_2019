using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DogTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Dog();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsMale);
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
        public void TestSetAge()
        {
            var item = new Dog();
            item.Age = 12;
            Assert.Equal(12, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Dog();

            try
            {
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Assert.Equal(0, item.Age);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Dog();

            try
            {
                item.Age = 12;
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Assert.Equal(12, item.Age);
            }
        }

    }
}
