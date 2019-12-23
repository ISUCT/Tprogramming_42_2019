using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Cat : Animal
    {
        public Cat()
        : this("Неизвестно")
        {
        }

        public Cat(string name)
        : this(name, 0)
        {
        }

        public Cat(string name, int age)
        : this(name, age, "Unknown")
        {
        }

        public Cat(string name, int age, string brood)
        : base(name, age)
        {
            Brood = brood;
        }

        public override int Age
        {
            set
            {
                if (value >= 0 && value < 16)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public string Brood { get; set; }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Порода:{Brood}";
        }

        public override void Voice()
        {
            Console.WriteLine("Мяу");
        }
    }
}
