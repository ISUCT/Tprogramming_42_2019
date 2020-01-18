using System;

namespace CourseApp
{
    public class Alien : Humanoid
    {
        public Alien()
        : this(0, "Somename", "Somesurname", true, "Mars")
        {
        }

        public Alien(int age, string name, string surname, bool isMale, string homeland)
       : base(10, name, surname, true)
        {
            Homeland = homeland;
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
        }

        public string Homeland { get; set; }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name} {Surname}: -alien speech-");
        }

        public override string ToString()
        {
            return $"Name:{Name}, Surname:{Surname}, Age:{Age}, Homeland:{Homeland}";
        }
    }
}