using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeTest
    {
        [Fact]
        public void TestDate()
        {
            Assert.Equal(new DateTime(09, 12, 2019), AgeClass.DateCompare(new DateTime(2001, 2, 5), new DateTime(2019, 12, 9)));
        }

        [Fact]
        public void WrongDate()
        {
        }
    }
}