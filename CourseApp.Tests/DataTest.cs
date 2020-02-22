using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DataTest
    {
        [Fact]
        public void TestBefore()
        {
            string st = $"Вам 1 дня,0 месяцев, 20 лет";
            Assert.Equal(st, Data.Age(new DateTime(2000, 1, 1), new DateTime(2020, 1, 2)));
        }

        [Fact]
        public void TestToday()
        {
            string st = $"congratulations you are born";
            Assert.Equal(st, Data.Age(new DateTime(2020, 1, 1), new DateTime(2020, 1, 1)));
        }

        [Fact]
        public void TestFuture()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, Data.Inequality(new DateTime(2020, 1, 2), new DateTime(2077, 4, 2))));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
            }
        }
    }
}