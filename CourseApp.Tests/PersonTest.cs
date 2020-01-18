using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Person();
            Assert.Equal(0, item.Age);
            Assert.Equal("Somename", item.Name);
            Assert.Equal("Somesurname", item.Surname);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void TestView()
        {
            var item = new Person();
            var view = "hello";
            Assert.Equal(view, item.ToString());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Person();
            item.Age = 26;
            Assert.Equal(26, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Person();
            try
            {
                item.Age = -5;
            }
            catch
            {
                Assert.Equal(0, item.Age);
                return;
            }

            Assert.True(false);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Person();
            item.Age = 27;
            try
            {
                item.Age = -1;
            }
            catch
            {
                Assert.Equal(27, item.Age);
                return;
            }

            Assert.Equal(27, item.Age);
        }

        [Fact]
        public void TestIncorrectSetString()
        {
            var item = new Person();
            try
            {
                item.Name = string.Empty;
            }
            catch (ArgumentNullException)
            {
                Assert.True(true);
            }

            try
            {
                item.Surname = string.Empty;
            }
            catch (ArgumentNullException)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectSetString()
        {
            var item = new Person();
            item.Name = "im so tired";
            item.Surname = "it is not a test it is a cry for help";
            Assert.Equal("im so tired", item.Name);
            Assert.Equal("it is not a test it is a cry for help", item.Surname);
        }
    }
}
