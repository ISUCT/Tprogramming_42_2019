using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PlatypusTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Mouse();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void TestView()
        {
            var item = new Mouse();
            var view = @"ᘛ⁐̤ᕐᐷ";
            Assert.Equal(view, item.View());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Mouse();
            item.Age = 2;
            Assert.Equal(2, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Mouse();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Mouse();
            item.Age = 2;
            item.Age = -5;
            Assert.Equal(2, item.Age);
        }
    }
}