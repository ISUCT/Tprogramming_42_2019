using System;

namespace CourseApp
{
    public class Programmer : Employee, ICoder
    {
        void ICoder.Code()
        {
            Console.WriteLine("Окей гугл, открой StackOverflow.");
        }
    }
}
