using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PigTest
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Pig();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal(0,item.countSalo);
        }

        [Fact]
        public void TestView()
        {
            var item = new Pig();
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