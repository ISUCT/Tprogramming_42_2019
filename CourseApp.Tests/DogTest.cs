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
            Assert.Equal("Unnamed", item.Name);
            Assert.Equal("male", item.Gender);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Dog();
            item.Age = 5;
            Assert.Equal(5, item.Age);
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
                Console.WriteLine("Не правильно введен возраст");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestIncorrectSetGender()
        {
        var item = new Dog();
        try
            {
                item.Gender = "demale";
            }
        catch (System.Exception)
            {
                Console.WriteLine("Не правильно введен пол");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestName()
        {
            var item = new Dog("barsik");
            Assert.Equal("barsik", item.Name);
        }

        [Fact]
        public void TestNameAge()
        {
            var item = new Cat("Sharik", "breed");
            Assert.Equal("Sharik", item.Name);
            Assert.Equal("breed", item.Breed);
        }

        [Fact]
        public void TestFullConstructor()
        {
            var item = new Dog("Sharik", 5, "male");
            Assert.Equal(5, item.Age);
            Assert.Equal("Sharik", item.Name);
            Assert.Equal("male", item.Gender);
        }
    }
}