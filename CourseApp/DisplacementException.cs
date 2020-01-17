using System;

namespace CourseApp
{
    public class DisplacementException : Exception
    {
        public DisplacementException(string message)
            : base(message)
        {
        }
    }
}