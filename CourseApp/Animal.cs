using System;

namespace CourseApp
{
    public abstract class Animal
    {
        public string Name { get; set; }
        private int age;

        public Animal()
        : this("Неизвестно")
        {
        }
        public Animal(string name)
        {
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
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
        public abstract void Voice();
    }
}
