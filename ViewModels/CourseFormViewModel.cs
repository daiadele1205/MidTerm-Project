﻿using MidTerm_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MidTerm_Project2.ViewModels
{
    public class CourseFormViewModel
    {
        public Course Course { get; set; }
        public string Title
        {
            get
            {
                if (Course != null && Course.Id != 0)
                    return "Edit Course";
                return "Create New Course";
            }
        }
    }
}