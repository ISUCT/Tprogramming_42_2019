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
        }

        public string Name { get; set; }

        public string Surname { get; set; }

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

        public bool IsPoisoned
        {
            get { return this.IsMale; }
        }

        public DateTime GetDate()
        {
            return dateOfEmploy;
        }

        public void Work(int days)
        {
            workDays += days;
            if (workDays >= 219)
            {
                age++;
                workDays = 0;
            }
        }

        public void Marry(string surname)
        {
            if (IsMale == false)
            {
                Surname = surname;
            }
        }

        public void Marry(Employee worker)
        {
            if (IsMale == false)
            {
                Surname = worker.Surname;
            }
        }
    }
}