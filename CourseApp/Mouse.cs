using System;

namespace CourseApp
{
    public class Mouse
    {
        private int age;

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

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 3)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 3");
                }
            }
        }

        public bool IsMale { get; set; }

        public string View()
        {
            return @"ᘛ⁐̤ᕐᐷ";
        }
    }
}
