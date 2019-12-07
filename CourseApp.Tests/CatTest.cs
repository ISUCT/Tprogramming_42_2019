using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CatTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Cat();
            Assert.Equal(0, item.Age);
            Assert.Equal("Unnamed", item.Name);
            Assert.Equal("male", item.Gender);
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
        var item = new Cat();
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
        var item = new Cat();
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
        public void Test()
        {
            var item = new Cat("barsik");
            Assert.Equal("barsik", item.Name);
        }

        [Fact]
        public void TestFullConstructor()
        {
            var item = new Cat("barsik", 5, "male");
            Assert.Equal(5, item.Age);
            Assert.Equal("barsik", item.Name);
            Assert.Equal("male", item.Gender);
        }
    }
}