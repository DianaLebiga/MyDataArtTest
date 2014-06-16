using System;
using System.Linq;
using Test2.DataBase.Tables;
using Test2.Exception.PersonException;

namespace Test2.Operations.PersonOperations
{
    public class ChangePersonOperation : BaseAddUpdatePersonOperation
    {
        public Person Person { get; set; }
        public Int32 PersonId { get; set; }
        public Person DbPerson { get; set; }

        public ChangePersonOperation(int personId, Person person)
        {
            Person = person;
            PersonId = personId;
        }

        protected override void BeforeTransaction()
        {
            CheckPerson(Person);

            DbPerson = (from p in Context.Persons
                            where p.Id == PersonId
                            select p).FirstOrDefault();
            if (DbPerson == null)
                throw new PersonWrongIdException(string.Format("Person with id {0} not found.", PersonId));
        }

        protected override void InTransaction()
        {
            var properties = Person.GetType().GetProperties().Where(p => p.Name != "Id");
            foreach (var prop in properties)
                prop.SetValue(DbPerson, prop.GetValue(Person));
     
            Context.SaveChanges();
        }

        protected override void AfterTransaction() { }
    }
}
