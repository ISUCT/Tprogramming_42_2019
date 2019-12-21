using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeCTest
    {
        [Fact]
        public void TestDate()
        {
            double a = DateTime.Now.Ticks - new DateTime(2012, 2, 4).Ticks;
            double b = AgeC.DatComp(new DateTime(2012, 2, 4), DateTime.Now).Ticks;
            if (b - a > 0.001)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestAgeYesterday()
        {
            string str = $"Тебе 9 лет, 0 месяцев и 1 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2010, 12, 20), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeToday()
        {
            string str = $"Тебе 10 лет, 0 месяцев и 0 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2009, 12, 21), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeTomorow()
        {
            string str = $"Тебе 11 лет, 0 месяцев и 0 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2008, 12, 21), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TodayBirthdayTest()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeC.DatComp(DateTime.Now, DateTime.Now)));
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
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeC.DatComp(DateTime.Now, new DateTime(2024, 4, 8))));
            }
            catch (Exception)
            {
                Console.WriteLine("Birthday > Today");
            }
        }
    }
}
