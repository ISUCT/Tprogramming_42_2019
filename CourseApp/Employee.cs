using System;

namespace CourseApp
{
    public class Employee : Person
    {
        private int workDays;

        public Employee()
        : this(14)
        {
        }

        public Employee(int age)
        : this(age, "Untitled")
        {
        }

        public Employee(int age, string name)
        : this(age, name, "Untitled")
        {
        }

        public Employee(int age, string name, string surname)
        : this(age, name, surname, true)
        {
        }

        public Employee(int age, string name, string surname, bool isMale)
        : this(age, name, surname, isMale, DateTime.Now)
        {
        }

        public Employee(int age, string name, string surname, bool isMale, DateTime date)
        : base(age, name, surname, isMale)
        {
            DateOfEmploy = date;
            workDays = 0;
            Products = 0;
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }

            set
            {
                if (value >= 14 && value < 100)
                {
                    base.Age = value;
                }
                else
                {
                    throw new AgeException("Age should be > 14 and < than 100");
                }
            }
        }

        public int Products { get; private set; }

        public DateTime DateOfEmploy { get; private set; }

        public void Work(int days)
        {
            if (days < 6)
            {
                workDays += days;
                if (workDays > 4)
                {
                    workDays = 0;
                    Products++;
                }
            }
            else
            {
                throw new WorkException("Working more than 5 days in a row is forbidden");
            }
        }

        public override string Relax()
        {
            return "Zzz...";
        }
    }
}