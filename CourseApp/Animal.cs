using System;
using System.Collections.Generic;

namespace CourseApp
{
    public abstract class Animal
    {
        private int age;

        public Animal()
        : this("Untitled")
        {
        }

        public Animal(string name)
        : this(0, name, true)
        {
        }

        public Animal(int age, string name, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
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
                if (value >= 0 && value < 20)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public bool IsMale { get; set; }

        public override string ToString()
        {
            return $"Имя:{Name}, Возраст:{Age}";
        }

        public void AgeDown()
        {
            this.Age--;
        }

        public abstract void SayAnything();
    }
}
