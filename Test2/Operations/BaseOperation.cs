using Test2.DataBase;

namespace Test2.Operations
{
    public class BaseOperation
    {
        public DataBaseContext Context { get; set; }
        protected virtual void BeforeTransaction() { }
     
        protected virtual void InTransaction() { }

        protected virtual void AfterTransaction() { }
       
        public void ExecuteTransactions()
        {
            try
            {
                Context = new DataBaseContext();

                BeforeTransaction();
                InTransaction();
                AfterTransaction();
            }
            catch (System.Exception exception)
            {
                throw;
            }
            finally
            {
                Context.Dispose();
            }
        }
    }
}
