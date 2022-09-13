using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Automible repair shop";
            

            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=car;integrated security=true");

            string myfile = @"C:\Users\Anjali.Saini\Desktop\Dot net\Day_29\Assessment\salary.txt";

           
            department d = new department();
            employee e = new employee();
            
            
            

            string isRepeat = "Y";

            while (isRepeat.ToUpper() == "Y")
            {
                Console.WriteLine("Press 1 to see employee salary");
                Console.WriteLine("Press 2 to see total repairing cost");
                Console.WriteLine("Press 3 to see car manufacturing cost");

                int n = int.Parse(Console.ReadLine());

                DataSet ds = new DataSet();

                switch (n)
                {
                    case 1:
                       
                        SqlDataAdapter da = new SqlDataAdapter("select e.emp_id,e.emp_name,w.work_hrs_monthly,d.hourly_salary" +
                            " from employee e inner join working_hrs w on e.emp_id=w.emp_id inner join department d on " +
                            "e.dep_id=d.dep_id", con);
                       
                        da.Fill(ds, "total");
                        int hrcount = ds.Tables["total"].Rows.Count;
                        if(File.Exists(myfile))
                            {
                            File.Delete(myfile);
                        }
                        int normal_hrs = 200;
                        for (int s = 0; s < hrcount; s++)
                        {
                            int total_salary;
                            int hrs_worked = (int)ds.Tables["total"].Rows[s][2];
                            int hrly_salary = (int)ds.Tables["total"].Rows[s][3];

                            total_salary = hrs_worked > normal_hrs ?
                                ((normal_hrs * hrly_salary) + (hrs_worked - normal_hrs) * hrly_salary * 2) :
                                (normal_hrs * hrly_salary);

                            if (!File.Exists(myfile))
                                using (StreamWriter sw = File.CreateText(myfile))
                                {
                                    sw.WriteLine($"EmpID : {ds.Tables["total"].Rows[s][0]} / " +
                                        $"Empname : {ds.Tables["total"].Rows[s][1]} / " +
                                        $"Salary : {total_salary}");
                                }
                            else
                                using (StreamWriter sw = File.AppendText(myfile))
                                {
                                    sw.WriteLine($"EmpID : {ds.Tables["total"].Rows[s][0]} / " +
                                        $"Empname : {ds.Tables["total"].Rows[s][1]} / " +
                                        $"Salary : {total_salary}");

                                }                           
                            
                        }
                        //action delegate
                        Action<string> printdel = department.print;

                        printdel("File created successfully");
                       
                        printdel("\nHere are the calculated salary:\n");

                        using (StreamReader sr = File.OpenText(myfile))
                        {
                            string sa = "";
                            while ((sa = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(sa);
                            }
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter the number of parts to be replaced");
                        int p = int.Parse(Console.ReadLine());
                        string[] parts = new string[p];
                        int i;
                        Console.WriteLine("Enter the parts name");
                        product pr = new product();
                        for (i=0;i<p;i++)
                        {
                            
                            Console.WriteLine();
                            parts[i] = Console.ReadLine();
                        }
                       
                        SqlDataAdapter da2 = new SqlDataAdapter("select * from product", con);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2, "part");
                        int count = ds2.Tables["part"].Rows.Count;
                        int totalprodcost = 0;
                        int price = 0;
                        int id;
                        foreach(string item in parts)
                        {
                            for(int j=0;j<count;j++)
                            {
                                if(ds2.Tables["part"].Rows[j][1].ToString()==item)
                                    {
                                    price = int.Parse(ds2.Tables["part"].Rows[j][2].ToString());
                                    totalprodcost += price;
                                    id = int.Parse(ds2.Tables["part"].Rows[j][0].ToString());
                                    SqlCommand cmd2 = new SqlCommand("update stock set prod_quantity=prod_quantity - 1 where prod_id=" + id + "", con);
                                    con.Open();
                                    cmd2.ExecuteNonQuery();
                                    con.Close();
                                    
                                }
                            }
                            
                        }
                        Console.WriteLine("stock table updated");

                        Console.WriteLine("total product cost " + totalprodcost);

                        

                        int h;
                        Console.WriteLine("Enter the number of hours taken to repair");
                        h = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the department name working on the repair");
                        d.dept_name = Console.ReadLine();

                        SqlDataAdapter da4 = new SqlDataAdapter("select * from department where dep_name='"+d.dept_name+"'", con);
                        da4.Fill(ds, "dep");
                        int manpower;
                        manpower = int.Parse(ds.Tables["dep"].Rows[0][2].ToString())*h;
                        Console.WriteLine("manpower : "+ manpower);

                        //func delegate

                        Func<int, int, int> rep = product.totalrepair;
                        Console.WriteLine("Total repairing cost :"+rep(totalprodcost,manpower));

                        break;
                    case 3:

                        SqlDataAdapter da3 = new SqlDataAdapter("select sum(prod_price) from product", con);
                        da3.Fill(ds,"total_parts_cost");
                        int parts_cost;
                        
                        parts_cost = int.Parse(ds.Tables["total_parts_cost"].Rows[0][0].ToString());

                        int labor_cost = 30000;

                        Console.WriteLine("Total manufacturing cost " + (parts_cost+labor_cost));

                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Do you want to continue Y/N");
                isRepeat = Console.ReadLine();

            }

        }
    }
}
