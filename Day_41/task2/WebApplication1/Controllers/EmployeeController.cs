using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {

        public ViewResult Details()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 102,
                Name = "Anjali",
                Salary = "50000",
                Gender = "Female"
            };
            Department dep = new Department
            {
                EmployeeId = 102,
                DeparmentId = 999,
                DepName = "CSE"
            };
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                employee = emp,
                department = dep,
                Title = "Employee Details",
                Header = "Employee Data"
            };
            return View(employeeDetailsViewModel);
        }
    }
}
