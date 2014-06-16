using System;
using System.ComponentModel.DataAnnotations;

namespace Test2.DataBase.Tables
{
    public class BaseTable
    {
        [Key]
        public Int32 Id { get; set; } 
    }
}
