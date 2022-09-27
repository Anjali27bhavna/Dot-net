using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetDetails(int id)
        {
            StudentBusinessLayer stubl = new StudentBusinessLayer();
            Student studentdetail = stubl.GetStudentById(id);
            return View(studentdetail);
        }
        public IActionResult GetStudentDetails(int id)
        {
            StudentRepository obj = new StudentRepository();
            Student stu = obj.GetStudentById(id);
            return View(stu);
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Student Index";
            return View();
        }

    }
}
