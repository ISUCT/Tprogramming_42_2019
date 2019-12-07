using System;

namespace CourseApp
{
    public class Programmer : Employee, ICoder
    {
        void ICoder.Code()
        {
            Console.WriteLine("OK Google, open StackOverflow.");
        }
    }
}
