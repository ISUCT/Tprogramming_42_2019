using System;
using Xunit;

namespace CourseApp.Tests
{
    public class VillageTest
    {
        [Theory]
        [InlineData("Name", 1, 18156)]
        [InlineData("Name1", 3, 95476)]
        public void TestConstructorThreeParametrs(string name, int population, int square)
        {
            var item = new Village(name, population, square);
            Assert.Equal(population, item.Population);
            Assert.Equal(name, item.Name);
            Assert.Equal(square, item.Square);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Village("Name", 300000);
            Assert.Equal(300000, item.Population);
            Assert.Equal("Name", item.Name);
            Assert.Equal(0, item.Square);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Village("Name2");
            Assert.Equal(1, item.Population);
            Assert.Equal("Name2", item.Name);
            Assert.Equal(0, item.Square);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Village();
            Assert.Equal(1, item.Population);
            Assert.Equal("Unnamed", item.Name);
            Assert.Equal(0, item.Square);
        }

        [Fact]
        public void TestSetPopulation()
        {
            var item = new Village();
            item.Population = 354900;
            Assert.Equal(354900, item.Population);
        }

        [Fact]
        public void TestIncorrectSetPopulation()
        {
            try
            {
                var item = new City();
                item.Population = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Population should be > 1");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetPopulation()
        {
            var item = new Village();
            try
            {
                item.Population = 10;
                item.Population = -5;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Population should be > 1");
                Assert.True(true);
            }

            Assert.Equal(10, item.Population);
        }
    }
}
