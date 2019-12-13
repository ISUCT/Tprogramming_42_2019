using System;
using System.Collections.Generic;

namespace RPG_autoBattler
{
    public class ProtectException : Exception
    {
        public ProtectException(string message)
            : base(message)
        {
        }
    }
}
