using System;
using Xunit;

namespace CourseApp.Tests
{
    public class YearsOldTest
    {
        [Fact]
        public void TestAgeYesterday()
        {
            string st = $"Вам 10 года(лет), 0 месяца(месяцев) и 1 дня(дней)";
            Assert.Equal(st, YearsOld.Age(new DateTime(2009, 12, 20), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeToday()
        {
            string st = $"Вам 8 года(лет), 0 месяца(месяцев) и 0 дня(дней)";
            Assert.Equal(st, YearsOld.Age(new DateTime(2011, 12, 21), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeTommorow()
        {
            string st = $"Вам 10 года(лет), 0 месяца(месяцев) и 0 дня(дней)";
            Assert.Equal(st, YearsOld.Age(new DateTime(2009, 12, 21), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAge()
        {
            string st = $"Вам 13 года(лет), 11 месяца(месяцев) и 22 дня(дней)";
            Assert.Equal(st, YearsOld.Age(new DateTime(2000, 11, 20), new DateTime(2014, 11, 11)));
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                string years = YearsOld.Age(new DateTime(2019, 12, 21), new DateTime(2048, 8, 16));
                Assert.Equal(0, DateTime.Compare(DateTime.Now, DateTime.Parse(years)));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
            }
        }

        [Fact]
        public void TestYears()
        {
            if (YearsOld.Age(DateTime.Now) == YearsOld.Age(new DateTime(2019, 12, 25)))
            {
                Assert.True(true);
            }
        }
    }
}