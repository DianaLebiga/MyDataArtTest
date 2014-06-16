namespace Test2.DataBase.Tables
{
    public class Person : BaseTable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual Job Job { get; set; }
    }
}
