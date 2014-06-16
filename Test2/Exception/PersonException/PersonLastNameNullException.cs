namespace Test2.Exception.PersonException
{
    public class PersonLastNameNullException : BaseException
    {
        public PersonLastNameNullException() { }

        public PersonLastNameNullException(string message) : base(message) { }
    }
}
