using System;

namespace CourseApp
{
    public class Person : Humanoid
    {
        public Person()
        : this(0, "Somename", "Somesurname", true)
        {
        }

        public Person(int age, string name, string surname, bool isMale)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
        }

        public override void SayAnything()
        {
            Console.WriteLine($"{Name} {Surname}: -human english speech-");
        }

        public override string ToString()
        {
            return "hello";
        }
    }
}