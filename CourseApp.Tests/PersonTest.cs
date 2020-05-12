using System;
using Xunit;

namespace CourseApp.Tests
{
    public class PersonTest
    {
        [Fact]
        public void IComparableStudentSortTest()
        {
            Student[] people = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Student();
                people[i].Age = 30 - i;
            }

            Array.Sort(people);
            for (int i = 0; i < people.Length - 1; i++)
            {
                if (people[i].Age > people[i + 1].Age)
                {
                    Assert.True(false);
                }
            }

            Assert.True(true);
        }

        [Fact]
        public void TestEmptyConstructorStud()
        {
            var item = new Student();
            Assert.Equal(0, item.Age);
            Assert.Equal("Untitled", item.Name);
            Assert.Equal("Untitled", item.Surname);
            Assert.True(item.IsMale);
            Assert.Equal(0, item.Scholarship);
        }

        [Fact]
        public void MarryTest1()
        {
            Student masha = new Student(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff", true);
            Assert.Equal("Pietroff", masha.Surname);
        }

        [Fact]
        public void MarryTest1i1()
        {
            Student masha = new Student(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff");
            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void MarryTest1i2()
        {
            Student masha = new Student(18, "Masha", "Romanoff", false);
            masha.Marry("Pietroff", false);
            Assert.Equal("Romanoff", masha.Surname);
        }

        [Fact]
        public void MarryTest2()
        {
            Student masha = new Student(18, "Masha", "Romanoff", false);
            Student vasya = new Student(22, "Vasya", "Vorobey", true);
            masha.Marry(vasya, true);
            Assert.Equal("Vorobey", masha.Surname);
        }

        [Fact]
        public void MarryTest3()
        {
            Student vasya = new Student(22, "Vasya", "Vorobey", true);
            vasya.Marry("Ivanoff", true);
            Assert.Equal("Vorobey", vasya.Surname);
        }

        [Fact]
        public void MarryTest4()
        {
            Student masha = new Student(18, "Masha", "Romanoff", false);
            Student vasya = new Student(22, "Vasya", "Vorobey", true);
            vasya.Marry(masha, true);
            Assert.Equal("Vorobey", vasya.Surname);
        }

        [Fact]
        public void MarryTest5()
        {
            Student masha = new Student(15, "Masha", "Romanoff", false);
            Student vasya = new Student(22, "Vasya", "Vorobey", true);
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
            Student masha = new Student(15, "Masha", "Romanoff", false);
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
        public void RelaxTest()
        {
            Person[] ms = new Person[2];
            ms[0] = new Student(18, "Vasya", "Ivanov");
            ms[1] = new Employee(35, "Vasiliy", "Petrov");
            Assert.Equal("Kawabunga!", ms[0].Relax());
            Assert.Equal("Zzz...", ms[1].Relax());
        }
    }
}