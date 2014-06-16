using System;
using System.Linq;
using Test2.DataBase.Tables;
using Test2.Exception.PersonException;

namespace Test2.Operations.PersonOperations
{
    public class DeletePersonOperation : BaseOperation
    {
        public Int32 PresonId { get; set; }
        public Person Person { get; set; }

        public DeletePersonOperation(int presonId)
        {
            PresonId = presonId;
        }

        protected override void BeforeTransaction()
        {
            Person = Context.Persons.FirstOrDefault(p => p.Id == PresonId);
            if (Person == null)
                throw new PersonIsNullException();
        }

        protected override void InTransaction()
        {
            Context.Persons.Remove(Person);
            Context.SaveChanges();
        }
    }
}
