using System;

namespace CourseApp
{
    public class Mouse : Animal
    {
        public Mouse()
        : this(0, "Untitled", true)
        {
        }

        public Mouse(int age, string name, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public Mouse(string name, string color)
        : base(name)
        {
            Color = color;
        }

        public string Color { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name}: *пищит по-крысячьи*");
        }

        public override string ToString()
        {
            return $"Имя:{Name}, Возраст:{Age}, Цвет:{Color}";
        }
    }
}
