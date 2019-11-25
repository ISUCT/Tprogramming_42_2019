using System;

namespace CourseApp
{
    public class WorkException : Exception
    {
        public WorkException(string message)
            : base(message)
        {
        }
    }
}