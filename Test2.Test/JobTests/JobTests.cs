using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2.DataBase;
using Test2.DataBase.Tables;
using Test2.Operations.JobOperations;

namespace Test2.Test.JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void Add()
        {
            const string jobName = "Economist";
            
            var jobAdd = new Job() { JobName = jobName };

            var op = new AddJobOperation(jobAdd);
            op.ExecuteTransactions();

            using (var db = new DataBaseContext())
            {
                var savedJob = db.Persons.FirstOrDefault(i => i.FirstName == jobName);
                Assert.IsNotNull(savedJob);

            }

        }
    }
}
