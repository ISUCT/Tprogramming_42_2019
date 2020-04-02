using System;
using System.Collections.Generic;

namespace RpgAutoBattler
{
    public class ProtectException : Exception
    {
        public ProtectException(string message)
            : base(message)
        {
        }
    }
}
