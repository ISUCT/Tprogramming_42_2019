using System;

namespace CourseApp
{
    public class Platypus
    {
        private int age;

        public Platypus()
        : this(0, "Untitled", true)
        {
        }

        public Platypus(int age, string name, bool isMale)
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

        public bool IsMale { get; set; }

        public bool IsPoisoned
        {
            get { return this.IsMale; }
        }

        public string View()
        {
            return @"
         _.-^~~^^^`~-,_,,~''''''```~,''``~'``~,
 ______,'  -o  :.  _    .          ;     ,'`,  `.
(      -\.._,.;;'._ ,(   }        _`_-_,,    `, `,
 ``~~~~~~'   ((/'((((____/~~~~~~'(,(,___>      `~'
 ";
        }
    }
}