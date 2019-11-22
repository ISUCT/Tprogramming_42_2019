using System;
using Xunit;

namespace CourseApp.Tests
{
    public class Doofenshmirtz
    {
        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Employee();
            DateTime dateExp = DateTime.Now;
            double sec = dateExp.Ticks / 10000000;
            var newSec = Math.Floor(sec / 60) * 60;
            var newTicks = (long)newSec * 10000000;
            dateExp = new DateTime(newTicks);
            DateTime dateReal = item.GetDate();
            sec = dateReal.Ticks / 10000000;
            newSec = Math.Floor(sec / 60) * 60;
            newTicks = (long)newSec * 10000000;
            dateReal = new DateTime(newTicks);
            Assert.Equal(dateExp, dateReal);
            Assert.Equal(14, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal("Untitled", item.Surname);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void MarryTest()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff");
            Assert.Equal("Pietroff", masha.Surname);
            Employee vasya = new Employee(22, "Vasya", "Vorobey", true);
            masha.Marry(vasya);
            Assert.Equal("Vorobey", masha.Surname);
            vasya.Marry("Ivanoff");
            Assert.Equal("Vorobey", vasya.Surname);
            masha.Surname = "Romanoff";
            vasya.Marry(masha);
            Assert.Equal("Vorobey", vasya.Surname);
            masha.Age = 15;
            masha.Marry(vasya);
            Assert.Equal("Romanoff", masha.Surname);
            masha.Marry("Gorobets");
            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Employee();
            item.Age = 20;
            Assert.Equal(20, item.Age);
        }

        [Theory]
        [InlineData(13, 14)]
        [InlineData(100, 14)]
        public void TestIncorrectSetAge(int age, int exp)
        {
            var item = new Employee();
            item.Age = age;
            Assert.Equal(exp, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Employee();
            item.Age = 20;
            item.Age = 13;
            Assert.Equal(20, item.Age);
        }

         [Fact]
         public void TestWork()
         {
             var item = new Employee();
             item.Work(219);
             Assert.Equal(15, item.Age);
         }/*

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
         }*/
    }
}