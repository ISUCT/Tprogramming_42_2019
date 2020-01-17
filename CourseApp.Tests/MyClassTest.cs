using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestMyClass
    {
        [Fact]
        public void TestSudno ()
        {
            var item = new Ship();
            Assert.Equal(0.0, item.Len);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal(0.0, item.Displacement);
            Assert.False(item.IsGoing);

        }

        [Fact]
        public void TestRiffShip ()
        {
            Sudno[] sudno = new Sudno[4];
            sudno[0] = new Ship("Корабль", 20, 20 );
            sudno[1] = new Boat("Лодка", 5, 25 );
            sudno[2] = new Ship("Корабль", 20, 20, true);
            sudno[3] = new Boat("Лодка", 5, 25, true );
            Assert.Equal("вы не в плаваньи",sudno[0].Riffs());
            Assert.Equal("вы не в плаваньи",sudno[1].Riffs());
            Assert.Equal("Ваш корабль сел на мель",sudno[2].Riffs());
            Assert.Equal("Так как у вас лодка вы не сели на мель",sudno[3].Riffs());
        }

    }
}