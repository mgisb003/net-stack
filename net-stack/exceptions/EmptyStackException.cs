using System;
using System.Collections.Generic;
using System.Text;

namespace net_stack.exceptions
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message) : base(message)
        {
        }
    }
}
