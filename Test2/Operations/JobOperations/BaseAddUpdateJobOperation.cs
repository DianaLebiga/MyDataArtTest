using Test2.DataBase.Tables;
using Test2.Exception.JobException;

namespace Test2.Operations.JobOperations
{
    public class BaseAddUpdateJobOperation : BaseOperation
    {
        protected void CheckJob(Job job)
        {
            if (job == null)
                throw new JobIsNullException();

            if (string.IsNullOrEmpty(job.JobName))
                throw new JobNameNullException("Job name is empty.");

            const int maxJobLength = (int)EnumJob.MaxJobLength;
            if (job.JobName.Length > maxJobLength)
                throw new JobNameLengthException(string.Format("Job name longer than {0} characters.", maxJobLength));
        }
    }
}