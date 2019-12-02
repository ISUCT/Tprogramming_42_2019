using System;

namespace CourseApp
{
    public class Student : Person
    {
        public Student()
        : base()
        {
        }

        public Student(int age)
        : base(age)
        {
        }

        public Student(int age, string name)
        : base(age, name)
        {
        }

        public Student(int age, string name, string surname)
        : base(age, name, surname)
        {
        }

        public Student(int age, string name, string surname, bool isMale)
        : base(age, name, surname, isMale)
        {
        }

        public int Scholarship { get; set; }

        public override string Relax()
        {
            return "Kawabunga!";
        }
    }
}