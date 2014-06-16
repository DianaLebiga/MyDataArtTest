using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.DataBase.Tables;
using Test2.Operations.PersonOperations;

namespace Test2.Test.PersonTests
{
    [TestClass]
    public class PersonChangeTests
    {
        [TestMethod]
        public void Delete()
        {
            var personDelete = new Person { Id = 7 };

            var op = new DeletePersonOperation(personDelete.Id);
            op.ExecuteTransactions();

            var searchOp = new SearchPersonByIdOperation(personDelete.Id);
            var delPerson = searchOp.ExecuteTransactions();
            Assert.IsNull(delPerson);
        }
    }
}
