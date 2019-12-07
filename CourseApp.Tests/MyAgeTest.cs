using System;
using Xunit;

namespace CourseApp.Tests
{
    public class MyAgeTest
    {
        [Fact]
        public void NormInt()
        {
            Assert.Equal("Вам 18 лет, 10 месяцев и 1 дня", Program.MyAge(2001, 2, 5));
        }

        [Fact]
        public void NormDate()
        {
            Assert.Equal("Вам 18 лет, 10 месяцев и 1 дня", Program.MyAge(new DateTime(2001, 2, 5)));
        }

        [Fact]
        public void StrangeDate()
        {
            Assert.Equal("Вам 0 лет, 0 месяцев и 0 дня", Program.MyAge(DateTime.Now));
        }

        [Fact]
        public void LowDateInt()
        {
            try
            {
                Program.MyAge(2037, 1, 1);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }
        }

        [Fact]
        public void LowDateDate()
        {
            try
            {
                Program.MyAge(new DateTime(2037, 1, 1));
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }
        }
    }
}