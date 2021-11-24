using MidTerm_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidTerm_Project2.Controllers
{
    public class StudentsController : Controller
    {
        private MidTermContext db = new MidTermContext();

        // List Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // Create New Student
        public ActionResult CreateNewStudent()
        {
            return View();
        }


        // Edit Student
        public ActionResult EditStudent()
        {
            return View();
        }

        // Delete Student
        public ActionResult DeleteStudent()
        {
            return View();
        }



        // Update Student
        public ActionResult UpdateStudent()
        {
            return View();
        }


    }
}