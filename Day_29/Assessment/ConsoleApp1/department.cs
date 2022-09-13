using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class department
    {
        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public int hourly_salary { get; set; }

        public static void print(string s)
        {
             Console.WriteLine(s);
        }
    }
}
