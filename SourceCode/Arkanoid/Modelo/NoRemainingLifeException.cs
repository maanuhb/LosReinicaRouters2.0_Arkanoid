using System;

namespace Arkanoid
{
    public class NoRemainingLifeException : Exception
    {
        public NoRemainingLifeException(string Message) : base(Message) { }
    }
}