using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.DataBase;
using Test2.DataBase.Tables;
using Test2.Exception.PersonException;
using Test2.Operations.PersonOperations;

namespace Test2.Test.PersonTests
{
    [TestClass]
    public class PersonAddTests : BasePersonTest
    {
        [TestMethod]
        public void Add()
        {
            //const string firstName = "Vasilij";
            //const string lastName = "Grek";
            //const int age = 46;
            //
            //var personAdd = new Person() { FirstName = firstName, LastName = lastName, Age = age };
            var personAdd = GetPerson;
            var op = new AddPersonOperation(personAdd);
            op.ExecuteTransactions();

            //var searchOp = new SearchPersonByIdOperation(personAdd.Id);
            //var addPerson = searchOp.ExecuteTransactions();
            var addedPeson = new SearchPersonByIdOperation(personAdd.Id).ExecuteTransactions();
            Assert.IsNotNull(addedPeson);

            //using (var context = new DataBaseContext())
            //    Assert.IsTrue(context.Persons.Any(p => p.Id == personAdd.Id));

            //var a = Guid.NewGuid().ToString();
        }

        [TestMethod]
        [ExpectedException(typeof (PersonAgeLengthException))]
        public void Test()
        {
            var person = GetPerson;
            person.Age = 100500;
            var addedPeson = new SearchPersonByIdOperation(person.Id).ExecuteTransactions();
        }
    }
}

