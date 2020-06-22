using System;

namespace Arkanoid
{
    public class ExceedMaxCharException : Exception
    {
        public ExceedMaxCharException(string Message) : base(Message) { }
    }
}