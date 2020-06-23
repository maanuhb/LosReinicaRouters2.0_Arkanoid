using System;

namespace Arkanoid
{
    public class OutOfBordersException :  Exception
    {
        public OutOfBordersException(string Message) : base(Message) { }
    }
}