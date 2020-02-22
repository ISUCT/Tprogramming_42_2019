using System;
using Xunit;

namespace CourseApp.Tests
{
    public class YourAgeTests
    {
        [Fact]
        public void YourAgeDate()
        {
            Assert.Equal(new DateTime(20, 2, 16), YourAge.DateComparison(new DateTime(2000, 11, 5), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void YourAgeStrig()
        {
            string result = YourAge.FromDateToDate(new DateTime(2000, 11, 1), new DateTime(2019, 10, 1));
            Assert.Equal("Вам 18 лет, 11 месяцев и 0 дня", result);
        }

        [Fact]
        public void NowDate2()
        {
            bool isWorking = false;
            try
            {
                YourAge.DateComparison(DateTime.Now, DateTime.Now);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                isWorking = true;
            }

            Assert.True(isWorking);
        }

        [Fact]
        public void FeatureDate()
        {
            bool isThrown = false;
            try
            {
                YourAge.YourAgeNow(2028, 12, 21);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                isThrown = true;
            }

            Assert.True(isThrown);
        }
    }
}