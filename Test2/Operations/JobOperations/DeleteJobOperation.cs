using System.Linq;
using Test2.DataBase.Tables;
using Test2.Exception.JobException;

namespace Test2.Operations.JobOperations
{
    public class DeleteJobOperation : BaseOperation
    {
        public Job Job { get; set; }

        public DeleteJobOperation(Job job)
        {
            Job = job;
        }

        protected override void BeforeTransaction()
        {
            Job = Context.Jobs.FirstOrDefault(p => p.Id == Job.Id);
            if (Job == null)
                throw new JobIsNullException();
        }

        protected override void InTransaction()
        {
            Context.Jobs.Attach(Job);
            Context.Jobs.Remove(Job);
            Context.SaveChanges();
        }

        protected override void AfterTransaction()
        {

        }
    }
}
