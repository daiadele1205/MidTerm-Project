using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.Models
{
    public class MidTermContext : DbContext
    {
        public MidTermContext() : base("name=MidTermContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}