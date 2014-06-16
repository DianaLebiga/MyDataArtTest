using System.Linq;
using Test2.DataBase.Tables;
using Test2.Exception.PersonException;

namespace Test2.Operations.PersonOperations
{
    public class SearchPersonByIdOperation : BaseOperation
    {
        public int PersonId { get; set; }

        public SearchPersonByIdOperation(int personId)
        {
            PersonId = personId;
        }

        private Person SearchResult { get; set; }

        protected override void InTransaction()
        {
            SearchResult = Context.Persons.FirstOrDefault(i => i.Id == PersonId);
            if (SearchResult == null)
                throw new PersonIsNullException();
            Context.SaveChanges();
        }

        public new Person ExecuteTransactions()
        {
            base.ExecuteTransactions();
            return SearchResult;
        }

    }
}
