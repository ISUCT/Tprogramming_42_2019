using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Pig
    {
        private int countSalo;
        private int age;

        public Pig()
        : this("Неизвестно")
        {
        }

        public Pig(string name)
        : this(name, 3)
        {
        }

        public Pig(string name, int age)
        : this(name, age, 0)
        {
        }

        public Pig(string name, int age, int countSalo)
        {
            Name = name;
            Age = age;
            CountSalo = countSalo;
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
                    Console.WriteLine("Age should be > 0 and < than 20");
                }
            }
        }

        public int CountSalo
        {
            get
            {
                return this.countSalo;
            }

            set
            {
                if (value >= 0)
                {
                    this.countSalo = value;
                }
                else
                {
                    Console.WriteLine("CountSalo should be > 0");
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя:{Name},Возраст:{Age},Кол-во сало:{CountSalo}");
        }

        public void Voice()
        {
            Console.WriteLine("Хрю");
        }

        public void Aging()
        {
            this.age++;
        }

        public void EatSalo()
        {
            this.countSalo--;
        }
    }
}
