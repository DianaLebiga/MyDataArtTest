using System;
using System.Linq;
using Test2.DataBase.Tables;
using Test2.Exception.JobException;

namespace Test2.Operations.JobOperations
{
    class ChangeJobOperation : BaseAddUpdateJobOperation
    {
        public Job Job { get; set; }
        public Int32 JobId { get; set; }
        public Person DbJob { get; set; }

        public ChangeJobOperation(int jobId, Job job)
        {
            Job = job;
            JobId = jobId;
        }


        protected override void BeforeTransaction()
        {
            CheckJob(Job);

            DbJob = (from p in Context.Persons
                        where p.Id == JobId
                        select p).FirstOrDefault();
            if (DbJob == null)
                throw new JobWrongIdException(string.Format("Person with id {0} not found.", JobId));
        }

        protected override void InTransaction()
        {
            var properties = Job.GetType().GetProperties().Where(p => p.Name != "Id");
            foreach (var prop in properties)
                prop.SetValue(DbJob, prop.GetValue(Job));

            Context.SaveChanges();
        }

        protected override void AfterTransaction() { }
    }
}
