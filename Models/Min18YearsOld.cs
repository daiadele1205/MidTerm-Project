using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.Models
{
    public class Min18YearsOld : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var Student = (Student)validationContext.ObjectInstance;

            if (Student.BirthDate == null)
                return new ValidationResult("BirthDate is required.");
            var Age = GetAge((DateTime)Student.BirthDate);

            return (Age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Student should be at least 18 years old");

        }



        public static Int32 GetAge(DateTime BirthDate)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (BirthDate.Year * 100 + BirthDate.Month) * 100 + BirthDate.Day;

            return (a - b) / 10000;
        }
    }
}