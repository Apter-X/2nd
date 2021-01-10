using System;
using System.Collections.Generic;
using System.Text;

namespace GCB.Manager
{
    class ExpectedException<T> : Exception
    {
        public ExpectedException(T value)
        : base("Value " + value + " of enum " + typeof(T).Name + " is not supported")
        {
        }
    }
}
