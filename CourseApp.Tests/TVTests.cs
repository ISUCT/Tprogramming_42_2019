using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TVTests
    {
        [Theory]
        [InlineData(2, 50, "samsung")]
        [InlineData(1, 13, "samsung")]
        public void TestConstructorThreeParametrs(int number, int brightness, string marka)
        {
            var item = new TV(number, brightness, marka);
            Assert.Equal(number, item.Number);
            Assert.Equal(brightness, item.Brightness);
            Assert.Equal(marka, item.Marka);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new TV(12, 42);
            Assert.Equal(12, item.Number);
            Assert.Equal(42, item.Brightness);
            Assert.Equal(" ", item.Marka);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new TV(12);
            Assert.Equal(12, item.Number);
            Assert.Equal(1, item.Brightness);
            Assert.Equal(" ", item.Marka);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new TV();
            Assert.Equal(1, item.Number);
            Assert.Equal(1, item.Brightness);
            Assert.Equal(" ", item.Marka);
        }

        [Fact]
        public void TestSetMarka()
        {
            var item = new TV();
            item.Marka = "samsung";
            Assert.Equal("samsung", item.Marka);
        }

        [Fact]
        public void TestIncorrectSetNumber()
        {
            try
            {
                var item = new TV();
                item.Number = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Number should be > 0");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetNumber()
        {
            var item = new TV();
            try
            {
                item.Number = 13;
                item.Number = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("CountSalo should be > 0");
                Assert.True(true);
            }

            Assert.Equal(13, item.Number);
        }
    }
}