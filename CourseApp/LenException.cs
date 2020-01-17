using System;

namespace CourseApp
{
    public class LenException : Exception
    {
        public LenException(string message)
            : base(message)
        {
        }
    }
}