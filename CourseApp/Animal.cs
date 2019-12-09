using System;

namespace CourseApp
{
    public abstract class Animal
    {
        private int age;

        public Animal()
        : this("Неизвестно")
        {
        }

        public Animal(string name)
        : this(name, 0)
        {
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Имя:{Name},Возраст:{Age}";
        }

        public void Aging()
        {
            this.age++;
        }

        public abstract void Voice();
    }
}
