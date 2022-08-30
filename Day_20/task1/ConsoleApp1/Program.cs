using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("a : ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("b : ");
            //    int b = int.Parse(Console.ReadLine());
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch ( Exception ex)
            //{
            //    Console.WriteLine("Error message is : " + ex);
            //}
            //finally
            //{
            //    Console.WriteLine("Good to see you here!!");
            //}

            //connection string
            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=employee;integrated security=true");

            Console.WriteLine("press 1 for insertion");
            Console.WriteLine("press 2 for deletion");
            Console.WriteLine("press 3 for updation");
            int n = int.Parse(Console.ReadLine());

            employee emp = new employee();
            switch (n)
            {
                case 1:
                    
                    Console.WriteLine("enter the id");
                    emp.id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter name of employee");
                    emp.name = Console.ReadLine();
                    Console.WriteLine("enter employee department");
                    emp.department = Console.ReadLine();
                    Console.WriteLine("enter employee salary");
                    emp.salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("enter employee gender");
                    emp.gender = Console.ReadLine();


                    //command creation
                    SqlCommand cmd = new SqlCommand("insert into employee_info values(" + emp.id + ",' " + emp.name + " ',' " + emp.department + " '," + emp.salary + ",' " + emp.gender + " ')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("record inserted");
                    break;

                case 2:
                    Console.WriteLine("enter the id");
                    emp.id = int.Parse(Console.ReadLine());
                    SqlCommand cmd1 = new SqlCommand("delete from employee_info where id=" + emp.id + " " , con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("record deleted");
                    break;
            }
           
            


            // ' " + emp.name + " ' string value
            // " + emp.
        }


    }
}
