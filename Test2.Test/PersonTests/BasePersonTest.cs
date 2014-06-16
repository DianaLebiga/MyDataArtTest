using System;
using Test2.DataBase.Tables;

namespace Test2.Test.PersonTests
{
    public class BasePersonTest
    {
        public Person GetPerson
        {
            get
            {
                return new Person
                {
                    FirstName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    Age = new Random().Next(100),
                    Job = new Job { JobName = Guid.NewGuid().ToString() }
                };
            }
        }
    }
}