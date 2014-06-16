using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.DataBase;
using Test2.DataBase.Tables;
using Test2.Operations.PersonOperations;

namespace Test2.Test.PersonTests
{
    [TestClass]
    public class PersonDeleteTests
    {
        [TestMethod]
        public void Change()
        {
            const int personId = 1;
            const string firstName = "Vasilij";
            const string lastName = "Grek";
            const int age = 22;

            var personChange = new Person {FirstName = firstName, LastName = lastName, Age = age};
            var op = new ChangePersonOperation(personId, personChange);
            op.ExecuteTransactions();

            var searchOp = new SearchPersonByIdOperation(personChange.Id);
            var changePerson = searchOp.ExecuteTransactions();
            Assert.IsNotNull(changePerson);

        }
    }
}