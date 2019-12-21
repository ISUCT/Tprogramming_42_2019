using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MyAgeTest
    {
        [Fact]
        public void NormDate()
        {
            Assert.Equal(new DateTime(19, 11, 4), MyAgeClass.DateCompar(new DateTime(2001, 2, 5), new DateTime(2019, 12, 9)));
        }

        [Fact]
        public void StringNormDate()
        {
            string result = MyAgeClass.DateComparS(new DateTime(1999, 12, 1), new DateTime(2019, 11, 1));
            Assert.Equal("Вам 19 лет, 11 месяцев и 1 дня", result);
        }

        [Fact]
        public void StringNormDateTomorrow()
        {
            string result = MyAgeClass.DateComparS(new DateTime(2000, 12, 2), new DateTime(2019, 12, 1));
            Assert.Equal("Вам 18 лет, 11 месяцев и 30 дня", result);
        }

        [Fact]
        public void StringNormDateToday()
        {
            string result = MyAgeClass.DateComparS(new DateTime(2000, 12, 1), new DateTime(2019, 12, 1));
            Assert.Equal("Вам 19 лет, 0 месяцев и 0 дня", result);
        }

        [Fact]
        public void StringNormDateYesterday()
        {
            string result = MyAgeClass.DateComparS(new DateTime(2000, 12, 1), new DateTime(2019, 12, 2));
            Assert.Equal("Вам 19 лет, 0 месяцев и 1 дня", result);
        }

        [Fact]
        public void StrangeDate()
        {
            bool isWorking = false;
            try
            {
                MyAgeClass.DateCompar(DateTime.Now, DateTime.Now);
            }
            catch (AgeException ex)
            {
                if (ex.Message == "Автору 0 лет")
                {
                    Console.WriteLine(ex.Message);
                    isWorking = true;
                }
            }

            Assert.True(isWorking);
        }

        [Fact]
        public void LowDate()
        {
            bool isThrown = false;
            try
            {
                MyAgeClass.MyAge(2037, 1, 1);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                isThrown = true;
            }

            Assert.True(isThrown);
        }
    }
}