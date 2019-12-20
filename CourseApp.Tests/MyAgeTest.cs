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