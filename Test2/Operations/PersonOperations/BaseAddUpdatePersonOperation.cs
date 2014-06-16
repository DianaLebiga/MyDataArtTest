using Test2.DataBase.Tables;
using Test2.Exception.PersonException;

namespace Test2.Operations.PersonOperations
{
    public class BaseAddUpdatePersonOperation : BaseOperation
    {
        protected void CheckPerson(Person person)
        {
            if (person == null)
                throw new PersonIsNullException();

            const int minPersonLength = (int)EnumPerson.MinPersonLength;
            if (person.Id == minPersonLength)
                throw new PersonWrongIdException(string.Format("Id of person is {0}.", minPersonLength));

            if (string.IsNullOrEmpty(person.FirstName))
                throw new PersonFirstNameNullException("First name is empty.");

            const int maxPersonLength = (int)EnumPerson.MaxPersonLength;
            if (person.FirstName.Length > maxPersonLength)
                throw new PersonFirstNameLengthException(string.Format(
                    "First name longer than {0} characters.", maxPersonLength));

            if (string.IsNullOrEmpty(person.LastName))
                throw new PersonLastNameLengthException("Last name is empty.");

            if (person.LastName.Length > maxPersonLength)
                throw new PersonLastNameNullException(string.Format(
                    "Last name longer than {0} characters.", maxPersonLength));


            const int maxPersonAge = (int)EnumPerson.MaxPersonAge;
            const int minPersonAge = (int)EnumPerson.MinPersonAge;
            if (person.Age > maxPersonAge && person.Age < minPersonAge)
                throw new PersonAgeLengthException("Age of person is out of range.");
        }
    }
}