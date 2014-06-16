using Test2.DataBase.Tables;
using Test2.Exception.JobException;

namespace Test2.Operations.JobOperations
{
    public class AddJobOperation : BaseAddUpdateJobOperation
    {
        public Job Job { get; set; }

        public AddJobOperation(Job job)
        {
            Job = job;
        }
        
        protected override void BeforeTransaction()
        {
            CheckJob(Job);
        }

        protected override void InTransaction()
        {
            Context.Jobs.Add(Job);
            Context.SaveChanges();
        }
    }
}
