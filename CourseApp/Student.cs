using System;

namespace CourseApp
{
    public class Student : Person
    {
        public Student()
        : base()
        {
            this.Scholarship = 0;
        }

        public Student(int age)
        : base(age)
        {
            this.Scholarship = 0;
        }

        public Student(int age, string name)
        : base(age, name)
        {
            this.Scholarship = 0;
        }

        public Student(int age, string name, string surname)
        : base(age, name, surname)
        {
            this.Scholarship = 0;
        }

        public Student(int age, string name, string surname, bool isMale)
        : base(age, name, surname, isMale)
        {
            this.Scholarship = 0;
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