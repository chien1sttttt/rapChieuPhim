using System;
using System.Collections.Generic;
using System.Text;

namespace rapChieuPhim.Utilities.Exceptions
{
    public class rapChieuPhimException : Exception
    {
        public rapChieuPhimException()
        {
        }

        public rapChieuPhimException(string message)
            : base(message)
        {
        }

        public rapChieuPhimException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
