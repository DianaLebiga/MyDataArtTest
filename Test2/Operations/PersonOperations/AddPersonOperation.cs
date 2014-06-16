using Test2.DataBase.Tables;
using Test2.Exception.PersonException;

namespace Test2.Operations.PersonOperations
{
    public class AddPersonOperation : BaseAddUpdatePersonOperation
    {
        public Person Person { get; set; }

        public AddPersonOperation(Person person)
        {
            Person = person;
        }
        
        protected override void BeforeTransaction()
        {
            CheckPerson(Person);
        }

        protected override void InTransaction()
        {
            Context.Persons.Add(Person);
            Context.SaveChanges();
        }
    }
}
