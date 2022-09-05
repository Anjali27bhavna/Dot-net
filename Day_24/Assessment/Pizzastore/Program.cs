using System;
using System.Data;
using System.Data.SqlClient;
using francls;
using empcls;
using ordercls;

namespace Pizzastore
{
    class Program
    {
        static void Main(string[] args)
        {
            orders ord = new orders();
            franchise fran = new franchise();
            employee emp = new employee();

            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=pizza;integrated security=true");

            Console.WriteLine("Enter your registered id and password : ");
            string logid = Console.ReadLine();
            string pass = Console.ReadLine();

            SqlDataAdapter da = new SqlDataAdapter("select * from login_details", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "login_details");
            int x = ds.Tables[0].Rows.Count;

            for (int i = 1; i < x; i++)
            {
                if (logid.ToString() == ds.Tables[0].Rows[i][0].ToString()) //franchise login
                {
                    if (pass.ToString() == ds.Tables[0].Rows[i][1].ToString())
                    {
                        string r = "Y";
                        

                        while (r.ToUpper()=="Y")
                        {
                            Console.WriteLine("Franchise logged in successfully!!");
                            Console.WriteLine("Press 1 to register employees");
                            Console.WriteLine("Press 2 to take order details");
                            Console.WriteLine("Press 3 for datewise order mode total sales ");
                            Console.WriteLine("Press 4 for employee salary distribution");
                            int a= int.Parse(Console.ReadLine());

                            switch(a)
                            {
                                case 1:
                                    

                                    Console.WriteLine("Enter the employee name : ");
                                    emp.emp_name = Console.ReadLine();
                                    Console.WriteLine("Enter the employee email : ");
                                    emp.email = Console.ReadLine();
                                    Console.WriteLine("Enter the employee phone no : ");
                                    emp.phone_no = Console.ReadLine();
                                    Console.WriteLine("Enter the employee franchise id : ");
                                    emp.f_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the employee salary : ");
                                    emp.salary = int.Parse(Console.ReadLine());

                                    SqlCommand cmd1 = new SqlCommand("insert into emp_details values('" + emp.emp_name + "','" + emp.email + "','" + emp.phone_no + "'," + emp.f_id + "," + emp.salary + ")", con);
                                    con.Open();
                                    cmd1.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("Employee registered successfully!!");

                                    break;
                                case 2:

                                    
                                    Console.WriteLine("Enter the type of order (dine in/take out) : ");
                                    ord.mode = Console.ReadLine();
                                    Console.WriteLine("Enter the pizza order : ");
                                    ord.pizza = Console.ReadLine();
                                    Console.WriteLine("Enter the order date : ");
                                    ord.order_date = Console.ReadLine();
                                    Console.WriteLine(ord.order_date);
                                    Console.WriteLine("Enter the employee id taken the order : ");
                                    ord.emp_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the amount of the order : ");
                                    ord.amount = int.Parse(Console.ReadLine());

                                    SqlCommand cmd2 = new SqlCommand("insert into order_details values('" + ord.mode + "','" + ord.pizza + "','" + ord.order_date + "'," + ord.emp_id + "," + ord.amount + ")", con);
                                    con.Open();
                                    cmd2.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("Order taken successfully!!");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the date : ");
                                    ord.order_date = Console.ReadLine();

                                    SqlDataAdapter da3 = new SqlDataAdapter("select mode,sum(amount) from order_details group by mode,order_date having order_date='" + ord.order_date + "'", con);
                                    DataSet ds3 = new DataSet();
                                    da3.Fill(ds3, "order_details");
                                    int sale = ds3.Tables["order_details"].Rows.Count;

                                    for (int j = 0; j < sale; j++)
                                    {
                                        Console.WriteLine("Order mode : " + ds3.Tables["order_details"].Rows[j][0].ToString());
                                        Console.WriteLine("total sales: " + ds3.Tables["order_details"].Rows[j][1].ToString());
                                    }


                                        break;
                                case 4:
                                    Console.WriteLine("Enter the franchise id for salary distribution");
                                    fran.f_id = int.Parse(Console.ReadLine());
                                    SqlCommand cmd4 = new SqlCommand("update franchise_details set " + "Salary_dist = Salary_dist  + 1 where f_id = " + fran.f_id + "", con);
                                    con.Open();
                                    cmd4.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("Salaries distributed for this month");
                                    break;
                            }
                            Console.WriteLine("Do you want to continue Y/N");
                            r = Console.ReadLine();

                        }
                    }
                }
            }


                if (logid.ToString() == ds.Tables[0].Rows[0][0].ToString())  //admin login
                {
                    if (pass.ToString() == ds.Tables[0].Rows[0][1].ToString())
                    {
                        string isRepeat = "Y";

                        while (isRepeat.ToUpper() == "Y")
                        {
                            Console.WriteLine("Admin Logged in successfully!!");
                            Console.WriteLine("press 1 to register franchise");
                            Console.WriteLine("press 2 for displaying franchise details");
                            Console.WriteLine("press 3 for datewise franchise sales");
                            Console.WriteLine("press 4 for total sales");
                            int n = int.Parse(Console.ReadLine());

                            

                            switch(n)
                            {
                                case 1:
                                    Console.WriteLine("Enter the location : ");
                                    fran.location = Console.ReadLine();
                                    Console.WriteLine("Enter the contact number : ");
                                    fran.phone_no= Console.ReadLine();
                                    Console.WriteLine("Enter the manager's name : ");
                                    fran.manager= Console.ReadLine();

                                    
                                    SqlCommand cmd = new SqlCommand("insert into franchise_details values('" + fran.location + "','" + fran.phone_no + "','" + fran.manager + "')", con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("Franchise registered successfully!!");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the franchise id to be searched ");
                                    fran.f_id = int.Parse(Console.ReadLine());

                                    SqlDataAdapter dataadap = new SqlDataAdapter("select * from franchise_details", con);
                                    dataadap.Fill(ds, "franchise");
                                    int num = ds.Tables[1].Rows.Count;


                                    for (int j = 0; j < num; j++)
                                    {
                                        if (fran.f_id.ToString() == ds.Tables[1].Rows[j][0].ToString())
                                        {
                                            Console.WriteLine("location : " + ds.Tables[1].Rows[j][1].ToString());
                                            Console.WriteLine("phone_no : " + ds.Tables[1].Rows[j][2].ToString());
                                            Console.WriteLine("manager : " + ds.Tables[1].Rows[j][3].ToString());
                                        }
                                    }
                                    break;
                               case 3:

                                Console.WriteLine("Enter the date : ");
                                ord.order_date = Console.ReadLine();

                                SqlDataAdapter da1 = new SqlDataAdapter("select e.f_id,sum(o.amount) from order_details as o inner join emp_details as e on o.emp_id = e.emp_id where o.order_date = '"+ord.order_date+"' group by e.f_id ", con);
                                DataSet ds1 = new DataSet();
                                da1.Fill(ds1, "order_details");
                                int sale = ds1.Tables["order_details"].Rows.Count;
                                

                                if(sale>0)
                                {
                                    for(int j=0;j<sale;j++)
                                    {
                                        Console.WriteLine("Franchise id : "+ ds1.Tables["order_details"].Rows[j][0].ToString());
                                        Console.WriteLine("Franchise sale : " + ds1.Tables["order_details"].Rows[j][1].ToString());
                                       
                                    }
                                    
                               }
                                else
                                {
                                    Console.WriteLine("There is no sale for today");
                                }

                                break;
                            case 4:
                                SqlDataAdapter da2 = new SqlDataAdapter("select sum(amount) from order_details", con);
                                DataSet ds2 = new DataSet();
                                da2.Fill(ds2, "order_details");
                                int sale1 = ds2.Tables["order_details"].Rows.Count;
                                
                                if(sale1>0)
                                {
                                    for (int j = 0; j < sale1; j++)
                                    {
                                        Console.WriteLine("Total sales : " + ds2.Tables["order_details"].Rows[j][0].ToString());
                                        
                                    }
                                    
                                }

                                break;
                                default:
                                    Console.WriteLine("Entered wrong id or password!!");
                                    break;
                            }
                            
                        Console.WriteLine("Do you want to continue Y/N");
                        isRepeat = Console.ReadLine();
                    }
                        
                    }
                }
        }
    }
}
