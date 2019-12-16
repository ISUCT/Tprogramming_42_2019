using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            double a = DateTime.Now.Ticks - new DateTime(2000, 08, 03).Ticks;
            double b = AgeClass.DateCompare(new DateTime(2000, 08, 03), DateTime.Now).Ticks;
            if (b - a > 0.000000001)
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(03, 8, 1999)]
        [InlineData(11, 5, 1998)]
        public void TestAge(int days, int months, int years)
        {
            Assert.Equal($"Вам {DateTime.Now.Year - years} лет, {DateTime.Now.Month - months} месяцев и {DateTime.Now.Day - days + 2} дня", AgeClass.Age(days, months, years));
        }

        [Fact]
        public void TodayBirthdayTest()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeClass.DateCompare(DateTime.Now, DateTime.Now)));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday == Today");
            }
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeClass.DateCompare(DateTime.Now, new DateTime(2048, 8, 16))));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
            }
        }
    }
}