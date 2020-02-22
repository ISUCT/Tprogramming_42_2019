using System;

namespace CourseApp
{
    public class Dog : Animal
    {
        public Dog()
        : this(0, "Untitled", true)
        {
        }

        public Dog(string name, string color)
       : base(name)
        {
            Color = color;
        }

        public Dog(int age, string name, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public string Color { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name}: *гавкает по-собачьи*");
        }

        public override string ToString()
        {
            return $"Имя:{Name}, Возраст:{Age}, Цвет:{Color}";
        }
    }
}
