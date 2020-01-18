using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Humanoid
    {
        private int age;
        private string name;
        private string surname;

        public Humanoid()
        : this("Somename", "Somesurname")
        {
        }

        public Humanoid(string name, string surname)
        : this(0, name, surname, true)
        {
        }

        public Humanoid(int age, string name, string surname, bool isMale)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("This field can't be empty.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("This field can't be empty.");
                }
                else
                {
                    this.surname = value;
                }
            }
        }

        public bool IsMale { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 200)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age should be > 0 and < than 20");
                }
            }
        }

        public override string ToString()
        {
            return $"Name:{Name}, Surname:{Surname}, Age:{Age}";
        }

        public void AgeDown()
        {
            this.Age--;
        }

        public abstract void SayAnything();
    }
}