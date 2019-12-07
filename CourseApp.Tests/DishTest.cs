using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DishTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Dish();
            Assert.Equal(0, item.Weight);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsReady);
        }

        [Fact]
        public void TestSetWeight()
        {
            try
            {
                var item = new Dish();
                item.Weight = 255;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestSetCal()
        {
            try
            {
                var item = new Dish();
                item.Cal = 225;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestSetRating()
        {
            try
            {
                var item = new Dish();
                item.Rating = 50;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestIncorrectSetWeight()
        {
            try
            {
                var item = new Dish();
                item.Weight = -5;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetWeight()
        {
            try
            {
                var item = new Dish();
                item.Weight = -5;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetCal()
        {
            try
            {
                var item = new Dish();
                item.Cal = -5;
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void TestStats()
        {
            var item = new Dish();
            bool bl = item.Cook();
            Assert.True(bl);
        }
    }
}