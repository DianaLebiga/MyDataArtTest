namespace Test2.Exception.JobException
{
    public class JobNameNullException : BaseException
    {
        public JobNameNullException() { }
        public JobNameNullException(string message) : base(message) { }
    }
}
