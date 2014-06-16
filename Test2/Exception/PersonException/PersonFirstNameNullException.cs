namespace Test2.Exception.PersonException
{
    public class PersonFirstNameNullException : BaseException
    {
        public  PersonFirstNameNullException()
        {
        }

        public PersonFirstNameNullException(string message)
            : base(message)
        {
        }
    }
}
