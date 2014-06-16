namespace Test2.Exception
{
    public class BaseException : System.Exception
    {
        public BaseException() { }

        public BaseException(string message) : base(message) { }
    }
}
