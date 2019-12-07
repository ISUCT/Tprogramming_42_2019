using System;

namespace CourseApp
{
    public class Dog
    {
        private int age;

        public Dog()
        : this(0, "Untitled", true)
        {
        }

        public Dog(int age, string name, bool isMale)
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
                if (value >= 0 && value < 15)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 15");
                }
            }
        }

        public bool IsMale { get; set; }

        public string Barking()
        {
            return "gav-gav";
        }
    }
}