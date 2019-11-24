using System;

namespace CourseApp
{
    public class AgeException : Exception
    {
        public AgeException(string message)
            : base(message)
        {
        }
    }
}