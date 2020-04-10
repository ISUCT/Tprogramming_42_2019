using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PlatypusTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Platypus();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void TestView()
        {
            var item = new Platypus();
            var view = @"
         _.-^~~^^^`~-,_,,~''''''```~,''``~'``~,
 ______,'  -o  :.  _    .          ;     ,'`,  `.
(      -\.._,.;;'._ ,(   }        _`_-_,,    `, `,
 ``~~~~~~'   ((/'((((____/~~~~~~'(,(,___>      `~'
 ";
            Assert.Equal(view, item.View());
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Platypus();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            var item = new Platypus();
            item.Age = -5;
            Assert.Equal(0, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Platypus();
            item.Age = 10;
            item.Age = -5;
            Assert.Equal(10, item.Age);
        }
    }
}
