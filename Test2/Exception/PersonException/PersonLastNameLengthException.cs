namespace Test2.Exception.PersonException 
{
    class PersonLastNameLengthException : BaseException
    {
        public PersonLastNameLengthException() { }

        public PersonLastNameLengthException(string message) : base(message) { }
    }
}
