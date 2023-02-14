using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Exceptions
{
    internal class RangeException : Exception
    {
        public RangeException() : base()
        {

        }

        public RangeException(string message) : base(message)
        {

        }
    }
}
