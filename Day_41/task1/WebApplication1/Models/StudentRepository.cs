using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StudentRepository:IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student(){StudentId=101,Name="Adam",Branch="CSE",Gender="Male",Section="A1"},
                new Student(){StudentId=101,Name="Sanam",Branch="HR",Gender="Male",Section="A3"}
            };
        }
        public Student GetStudentById(int id)
        {
            var stu = DataSource().FirstOrDefault(e => e.StudentId == id);
            return stu;
        }
    }
}
