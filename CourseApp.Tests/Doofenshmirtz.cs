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
            long a = Math.Abs(dateExp.Ticks - item.DateOfEmploy.Ticks);
            Assert.True(a < 10000001);
            Assert.Equal(14, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal("Untitled", item.Surname);
            Assert.True(item.IsMale);
        }

        [Fact]
        public void MarryTest1()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff", true);
            Assert.Equal("Pietroff", masha.Surname);
        }

        [Fact]
        public void MarryTest1i1()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff");
            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void MarryTest1i2()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff", false);
            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void MarryTest2()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            Employee vasya = new Employee(22, "Vasya", "Vorobey", true);
            masha.Marry(vasya, true);
            Assert.Equal("Vorobey", masha.Surname);
        }

        [Fact]
        public void MarryTest3()
        {
            Employee vasya = new Employee(22, "Vasya", "Vorobey", true);
            vasya.Marry("Ivanoff", true);
            Assert.Equal("Vorobey", vasya.Surname);
        }

        [Fact]
        public void MarryTest4()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false);
            Employee vasya = new Employee(22, "Vasya", "Vorobey", true);
            vasya.Marry(masha, true);
            Assert.Equal("Vorobey", vasya.Surname);
        }

        [Fact]
        public void MarryTest5()
        {
            Employee masha = new Employee(15, "Masha", "Romanoff", false);
            Employee vasya = new Employee(22, "Vasya", "Vorobey", true);
            try
            {
                masha.Marry(vasya, true);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }

            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void MarryTest6()
        {
            Employee masha = new Employee(15, "Masha", "Romanoff", false);
            try
            {
                masha.Marry("Gorobets", true);
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }

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
            try
            {
                item.Age = age;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }

            Assert.Equal(exp, item.Age);
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Employee();
            item.Age = 20;
            try
            {
                item.Age = 13;
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }

            Assert.Equal(20, item.Age);
        }

        [Fact]
        public void TestReport()
        {
            Employee masha = new Employee(18, "Masha", "Romanoff", false, DateTime.MinValue);
            Assert.Equal("Good day, sir! I am Masha Romanoff. I am 18 years old. And also I am a female by the way.", masha.ToString());
        }

        [Fact]
         public void TestWork()
         {
             var item = new Employee();
             item.Work(5);
             Assert.Equal(1, item.Products);
        }

        [Fact]
        public void TestWork2()
        {
            var item = new Employee();
            try
            {
                item.Work(10);
            }
            catch (WorkException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.True(true);
            }

            Assert.Equal(0, item.Products);
        }
    }
}