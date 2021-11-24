using MidTerm_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.ViewModels
{
    public class StudentFormViewModel
    {
        public Models.Student Student { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public string Title
        {
            get
            {
                if (Student != null && Student.Id != 0)
                    return "Edit Student";
                return "Create New Student";
            }
        }
    }
}