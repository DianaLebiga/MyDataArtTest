namespace Test2.Exception.PersonException
{
    public class PersonIsNullException : BaseException
    {
        public PersonIsNullException() { }

        public PersonIsNullException(string message) : base(message) { }
    }
}
