namespace Test2.Exception.JobException 
{
    public class JobIsNullException : BaseException
    {
        public JobIsNullException() { }

        public JobIsNullException(string message) : base(message) { }
    }
}
