using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Pig : Animal
    {
        private int countSalo;

        public Pig()
        : base("Неизвестно")
        {
        }

        public Pig(string name)
        : base(name, 0)
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
                throw new System.Exception();
                }
            }
        }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age},Кол-во сало:{CountSalo}";
        }

        public override void Voice()
        {
            Console.WriteLine("Хрю");
        }

        public void EatSalo()
        {
            this.countSalo--;
        }
    }
}
