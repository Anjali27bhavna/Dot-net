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
                    
                     case 3:
                        Console.WriteLine("Enter the id to be updated");
                        emp.id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name of employee");
                        emp.name = Console.ReadLine();
                        Console.WriteLine("Enter department of employee");
                        emp.department = Console.ReadLine();
                        Console.WriteLine("Enter gender of employee");
                        emp.gender = Console.ReadLine();

                        SqlCommand cmd2 = new SqlCommand("update emp_details set name= '" + emp.name + "', department= '" + emp.department + "',gender='" + emp.gender + "' where id=" + emp.id + "", con);

                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        Console.WriteLine("Record updated successfully!!");
                        break;
                    case 4:
                        Console.WriteLine("Enter the id to be searched");
                        emp.id = int.Parse(Console.ReadLine());
                        SqlDataAdapter da = new SqlDataAdapter("select * from emp_details", con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "emp_details");
                        int x = ds.Tables[0].Rows.Count;
                        Console.WriteLine("records found: " + x);

                        for (int i = 0; i < x; i++)
                        {
                            if (emp.id.ToString() == ds.Tables[0].Rows[i][0].ToString())
                            {
                                Console.WriteLine("Name: " + ds.Tables[0].Rows[i][1].ToString());
                                Console.WriteLine("Department: " + ds.Tables[0].Rows[i][2].ToString());
                                Console.WriteLine("Gender: " + ds.Tables[0].Rows[i][3].ToString());
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong Input!!");
                        break;

            }
           
            


            // ' " + emp.name + " ' string value
            // " + emp.
        }


    }
}
