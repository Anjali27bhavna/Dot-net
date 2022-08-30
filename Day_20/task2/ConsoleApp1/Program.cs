using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=bank;integrated security=true");
            try
            {
                Console.WriteLine( "Enter your registered id and password : ");
                int logid = int.Parse(Console.ReadLine());
                string pass = Console.ReadLine();

                SqlDataAdapter da = new SqlDataAdapter("select * from login_details", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "login_details");
                int x= ds.Tables[0].Rows.Count;

                for(int i=0;i<x;i++)
                {
                    if(logid.ToString()==ds.Tables[0].Rows[i][0].ToString())
                    {
                        if(pass.ToString()==ds.Tables[0].Rows[i][1].ToString())
                        {
                            string isRepeat = "Y";

                            while(isRepeat.ToUpper() =="Y")
                            {
                                Console.WriteLine("Logged in successfully!!");
                                Console.WriteLine("press 1 for insertion");
                                Console.WriteLine("press 2 for deletion");
                                Console.WriteLine("press 3 for updation");
                                Console.WriteLine("press 4 for displaying");
                                int n = int.Parse(Console.ReadLine());

                                customerinfo customer = new customerinfo();
                                switch (n)
                                {
                                    case 1:
                                        Console.WriteLine("Enter customer name : ");
                                        customer.name = Console.ReadLine();
                                        Console.WriteLine("Enter customer age : ");
                                        customer.age =int.Parse( Console.ReadLine());
                                        Console.WriteLine("Enter customer address : ");
                                        customer.address = Console.ReadLine();
                                        Console.WriteLine("Enter customer phone : ");
                                        customer.phone = Console.ReadLine();
                                        Console.WriteLine("Enter customer email : ");
                                        customer.email = Console.ReadLine();

                                       
                                            SqlCommand cmd = new SqlCommand("insert into customer_details values('" + customer.name + "', " + customer.age + ", '" + customer.address + " ', '" + customer.phone + "','" + customer.email + "')", con);
                                            con.Open();
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            Console.WriteLine("record inserted");
                                         break;

                                    case 2:
                                        Console.WriteLine("enter the id");
                                        
                                        customer.id = int.Parse(Console.ReadLine());
                                        SqlCommand cmd1 = new SqlCommand("delete from customer_details where custid=" + customer.id + " ", con);
                                        con.Open();
                                        cmd1.ExecuteNonQuery();
                                        con.Close();
                                        Console.WriteLine("record deleted");
                                        break;

                                    case 3:
                                        Console.WriteLine("enter the id to be updated");
                                        customer.id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter customer name : ");
                                        customer.name = Console.ReadLine();
                                        Console.WriteLine("Enter customer age : ");
                                        customer.age = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter customer address : ");
                                        customer.address = Console.ReadLine();
                                        Console.WriteLine("Enter customer phone : ");
                                        customer.phone = Console.ReadLine();
                                        Console.WriteLine("Enter customer email : ");
                                        customer.email = Console.ReadLine();

                                        
                                        SqlCommand cmd2 = new SqlCommand("update customer_details set name='" + customer.name + "',age=" + customer.age + ",address='" + customer.address + "',phone='" + customer.phone + "',email='" + customer.email + "'where  custid=" + customer.id + "", con);
                                        con.Open();
                                        cmd2.ExecuteNonQuery();
                                        con.Close();
                                        Console.WriteLine("Record updated successfully!!");
                                        break;

                                    case 4:
                                        SqlDataAdapter dataadap = new SqlDataAdapter("select * from customer_details",con);
                                        dataadap.Fill(ds, "customer_details");
                                        int num = ds.Tables[1].Rows.Count;
                                        for (int j=0;j<num;j++)
                                        {
                                            Console.WriteLine("Name : " + ds.Tables[1].Rows[j][1].ToString());
                                            Console.WriteLine("Age : " + ds.Tables[1].Rows[j][2].ToString());
                                            Console.WriteLine("Address : " + ds.Tables[1].Rows[j][3].ToString());
                                            Console.WriteLine("Phone : " + ds.Tables[1].Rows[j][4].ToString());
                                            Console.WriteLine("email : " + ds.Tables[1].Rows[j][5].ToString());
                                        }
                                        break;

                                }

                                Console.WriteLine("Do you want to continue Y/N");
                                isRepeat = Console.ReadLine();
                            }
                        }
                    }
                }
            }
            catch { }
        }
    }
}
