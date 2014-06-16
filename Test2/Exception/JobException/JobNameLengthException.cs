using System;
namespace Test2.Exception.JobException
{
    class JobNameLengthException : BaseException
    {
        public JobNameLengthException() { }

        public JobNameLengthException(string message) : base(message) { }
    }
}
