using System;

namespace CourseApp
{
    public class Employee
    {
        private int age;
        private int workDays;
        private DateTime dateOfEmploy;

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
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
            dateOfEmploy = date;
            workDays = 0;
            Products = 0;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Products { get; private set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 14 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 14 and < than 100");
                }
            }
        }

        public bool IsMale { get; set; }

        public DateTime GetDate()
        {
            return dateOfEmploy;
        }

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
                Console.WriteLine("Working more than 5 days in a row is forbidden");
            }
        }

        public void Marry(string surname, bool change = false)
        {
            if (Age > 15)
            {
                if ((IsMale == false) && change)
                {
                    Surname = surname;
                }
            }
        }

        public void Marry(Employee worker, bool change = false)
        {
            if (Age > 15)
            {
                if ((IsMale == false) && change)
                {
                    Surname = worker.Surname;
                }
            }
        }

        public override string ToString()
        {
            string s = $"Good day, sir! I am {Name} {Surname}. I am {Age} years old. And also I am a {(IsMale ? "male" : "female")} by the way.";
            return s;
        }
    }
}