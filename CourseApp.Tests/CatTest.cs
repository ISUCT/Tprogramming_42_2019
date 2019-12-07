using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CatTest
    {
        [Theory]
        [InlineData("Name", 1, "brood1")]
        [InlineData("Name1", 3, "brood2")]
        public void TestConstructorThreeParametrs(string name, int age, string brood)
        {
            var item = new Cat(name, age, brood);
            Assert.Equal(age, item.Age);
            Assert.Equal(name, item.Name);
            Assert.Equal(brood, item.Brood);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Cat("Name2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Name2", item.Name);
            Assert.Equal("Unknown", item.Brood);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Cat("Name3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Name3", item.Name);
            Assert.Equal("Unknown", item.Brood);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Cat();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Name);
            Assert.Equal("Unknown", item.Brood);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Cat();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Cat();
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("CountSalo should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Cat();
            try
            {
                item.Age = 10;
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("CountSalo should be > 0");
                Assert.True(true);
            }

            Assert.Equal(10, item.Age);
        }
    }
}
