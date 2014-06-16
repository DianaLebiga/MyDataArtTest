namespace Test2.Exception.PersonException 
{
    class PersonFirstNameLengthException : BaseException
    {
        public PersonFirstNameLengthException() { }

        public PersonFirstNameLengthException(string message) : base(message) { }
    }
}
