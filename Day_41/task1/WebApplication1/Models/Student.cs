using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
    }
    public class StudentBusinessLayer
    {
        public Student GetStudentById(int StudentId)
        {
            Student student = new Student()
            {
                StudentId = StudentId,
                Name = "James",
                Gender = "Male",
                Branch = "CSE",
                Section = "A2"
            };
            return student;
        }
    }
}
