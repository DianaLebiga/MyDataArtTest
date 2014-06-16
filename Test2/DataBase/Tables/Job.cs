using System.Collections.Generic;

namespace Test2.DataBase.Tables
{
    public class Job : BaseTable
    {
        public string JobName { get; set; }
        public virtual List<Person> Persons { get; set; }
        public Job()
        {
            Persons = new List<Person>();
        }
    }
}
