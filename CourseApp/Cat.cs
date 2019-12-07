using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Cat
    {
        private int age;

        private string gender;

        public Cat()
        : this("Unnamed")
        {
        }

        public Cat(string name)
        : this(name, 0, "male")
        {
        }

        public Cat(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 21)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (value == "male" || value == "female")
                {
                    this.gender = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

         public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Пол:{Gender}";
        }

        public void SayMeow()
        {
            Console.WriteLine($"{Name}:Мяу");
        }

        public void AgeUp()
        {
            this.age++;
        }
    }
}
