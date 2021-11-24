using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.Models
{
    public enum CourseStatus
    {
        [Display(Name = "1 - In Progress")]
        InProgress = 1,

        [Display(Name = "2 - Completed")]
        Completed = 2
    }
    public enum Grade
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        F = 5
    }
    public class Student
    {
        public int Id { get; set; }


        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [Required]
        [DisplayName("Date of Birth")]
        [Min18YearsOld]
        public DateTime BirthDate { get; set; }



        [Required]
        [DisplayName("Course Id")]
        public int CourseId { get; set; }



        [Required]
        [DisplayName("Course Enrolled Date")]
        public DateTime CourseEnrolledDate { get; set; }



        [Required]
        [DisplayName("Course Status")]
        public CourseStatus? CourseStatus { get; set; }



        [DisplayName("Grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
    }
}