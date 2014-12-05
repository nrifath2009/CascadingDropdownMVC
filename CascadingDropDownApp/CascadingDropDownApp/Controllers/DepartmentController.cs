using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropDownApp.Models;

namespace CascadingDropDownApp.Controllers
{
    public class DepartmentController : Controller
    {
        private List<Student> students = new List<Student>()
        {
            
            new Student(){StudentId = 1,Name = "A",DepartmentId = 1},
             new Student(){StudentId = 1,Name = "B",DepartmentId = 2},
             new Student(){StudentId = 1,Name = "D",DepartmentId = 3},
             new Student(){StudentId = 1,Name = "E",DepartmentId = 3},
             new Student(){StudentId = 1,Name = "G",DepartmentId = 1},
             new Student(){StudentId = 1,Name = "J",DepartmentId = 2}


        }; 
        //
        // GET: /Department/
        public ActionResult Index()
        {
            List<Department> departments = new List<Department>
            {
                new Department()
                {
                    DepartmentId = 1, Name = "Computer Science"
                },
                new Department()
                {
                    DepartmentId = 2, Name = "Electrical & Electronics"
                },
                 new Department()
                {
                    DepartmentId = 3, Name = "Information Technology"
                }

            };

            ViewBag.Departments = departments;
            return View();
        }

        public JsonResult GetStudentsByDepartmentId(int departmentId)
        {
            var studentList = students.Where(a => a.DepartmentId == departmentId).ToList();
            return Json(studentList, JsonRequestBehavior.AllowGet);

        }
        //[HttpPost]
        //public List<Student> GetStudentsByDepartmentId(int departmentId)
        //{
        //    List<Student> studentList = students.Where(a => a.DepartmentId == departmentId).ToList();
        //    return studentList;

        //}

	}
}