using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.Models
{
    public class Course
    {
        public int Id { get; set; }


        [DisplayName("Course Name")]
        public string CourseName { get; set; }


        [DisplayName("Course Description")]
        public string CourseDescription { get; set; }


        [DisplayName("Tutor Name")]
        public string TutorName { get; set; }


        [DisplayName("Course Rating")]
        [Range(1, 10)]
        public int CourseRating { get; set; }
    }
}