using System;

namespace Arkanoid
{
    public class EmptyNicknameException : Exception
    {
        public EmptyNicknameException(string Message) : base(Message) { }
    }
}