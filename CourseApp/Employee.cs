using System;

namespace CourseApp
{
    public class Employee
    {
        private int age;
        private DateTime dateOfEmploy;

        public Employee()
        : this(14)
        {
        }

        public Employee(int age)
        : this(age, "Untitled")
        {
        }

        public Employee(int age, string name)
        : this(age, name, true)
        {
        }

        public Employee(int age, string name, bool isMale)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
            dateOfEmploy = DateTime.Now;
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