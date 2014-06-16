namespace Test2.Exception.JobException
{
    class JobWrongIdException : BaseException
    {
        public JobWrongIdException() { }

        public JobWrongIdException(string message) : base(message) { }
       
    }
}
