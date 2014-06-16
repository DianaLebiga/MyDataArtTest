using System.Data.Entity;
using Test2.DataBase.Tables;

namespace Test2.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}
