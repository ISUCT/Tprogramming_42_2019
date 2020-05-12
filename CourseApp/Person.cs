using System;

namespace CourseApp
{
    public abstract class Person
    {
        private int age;

        public Person()
        : this(0)
        {
        }

        public Person(int age)
        : this(age, "Untitled")
        {
        }

        public Person(int age, string name)
        : this(age, name, "Untitled")
        {
        }

        public Person(int age, string name, string surname)
        : this(age, name, surname, true)
        {
        }

        public Person(int age, string name, string surname, bool isMale)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new AgeException("Age should be > 0 and < than 100");
                }
            }
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsMale { get; set; }

        public int CompareTo(Person p)
        {
            return this.Age.CompareTo(p.Age);
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
            else
            {
                throw new AgeException("You can marry from 16 years in Russia");
            }
        }

        public void Marry(Person worker, bool change = false)
        {
            if (Age > 15)
            {
                if ((IsMale == false) && change)
                {
                    Surname = worker.Surname;
                }
            }
            else
            {
                throw new AgeException("You can marry from 16 years in Russia");
            }
        }

        public override string ToString()
        {
            string s = $"Good day, sir! I am {Name} {Surname}. I am {Age} years old. And also I am a {(IsMale ? "male" : "female")} by the way.";
            return s;
        }

        public abstract string Relax();
    }
}
