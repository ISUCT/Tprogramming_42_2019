using System;

namespace CourseApp
{
    public class Student : Person
    {
        public Student()
        : this(0)
        {
        }

        public Student(int age)
        : this(age, "Untitled")
        {
        }

        public Student(int age, string name)
        : this(age, name, "Untitled")
        {
        }

        public Student(int age, string name, string surname)
        : this(age, name, surname, true)
        {
        }

        public Student(int age, string name, string surname, bool isMale)
        : this(age, name, surname, isMale, 0)
        {
        }

        public Student(int age, string name, string surname, bool isMale, int scholarship)
        : base(age, name, surname, isMale)
        {
            this.Scholarship = scholarship;
        }

        public int Scholarship { get; set; }

        public override string Relax()
        {
            return "Kawabunga!";
        }
    }
}