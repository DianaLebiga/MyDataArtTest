namespace Test2.Exception.PersonException
{
    class PersonWrongIdException : BaseException
    {
        public PersonWrongIdException() { }

        public PersonWrongIdException(string message) : base(message) { }
       
    }
}
