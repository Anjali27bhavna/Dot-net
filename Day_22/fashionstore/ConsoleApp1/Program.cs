using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        enum categories
        {
            cosmetic,
            footwear,
            garments
        }
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=fstore;integrated security=true");

            Console.WriteLine("Enter your registered id and password : ");
            int logid = int.Parse(Console.ReadLine());
            string pass = Console.ReadLine();

            SqlDataAdapter da = new SqlDataAdapter("select * from login_details", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "login_details");
            int x = ds.Tables[0].Rows.Count;

            for (int i = 0; i < x; i++)
            {
                if (logid.ToString() == ds.Tables[0].Rows[i][0].ToString())
                {
                    if (pass.ToString() == ds.Tables[0].Rows[i][1].ToString())
                    {
                        string isRepeat = "Y";

                        while (isRepeat.ToUpper() == "Y")
                        {
                            Console.WriteLine("Logged in successfully!!");
                            Console.WriteLine("press 1 for insertion");
                            Console.WriteLine("press 2 for deletion");
                            Console.WriteLine("press 3 for updation");
                            Console.WriteLine("press 4 for displaying");
                            Console.WriteLine("press 5 for showing details of products with name length greater than 5");
                            int n = int.Parse(Console.ReadLine());

                            productinfo prod = new productinfo();

                            switch(n)
                            {
                                case 1:
                                    Console.WriteLine("Enter the product name : ");
                                    prod.p_name = Console.ReadLine();
                                    Console.WriteLine("Enter the product price : ");
                                    prod.price = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the product quantity : ");
                                    prod.quantity = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the category id : ");
                                    prod.c_id = int.Parse(Console.ReadLine());

                                    SqlCommand cmd = new SqlCommand("insert into product values('" + prod.p_name + "', " + prod.price + ", " + prod.quantity + " , " + prod.c_id + ")", con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("record inserted");

                                    break;

                                case 2:
                                    Console.WriteLine("enter the product id");

                                    prod.p_id = int.Parse(Console.ReadLine());
                                    SqlCommand cmd1 = new SqlCommand("delete from product where p_id=" + prod.p_id + " ", con);
                                    con.Open();
                                    cmd1.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("record deleted");
                                    break;

                                case 3:
                                    Console.WriteLine("enter the id to be updated");
                                    prod.p_id = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the product name : ");
                                    prod.p_name = Console.ReadLine();
                                    Console.WriteLine("Enter the product price : ");
                                    prod.price = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the product quantity : ");
                                    prod.quantity = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the category id : ");
                                    prod.c_id = int.Parse(Console.ReadLine());


                                    SqlCommand cmd2 = new SqlCommand("update product set p_name='" + prod.p_name + "',price=" + prod.price + ",quantity=" + prod.quantity + ",c_id=" + prod.c_id + "where  p_id=" + prod.p_id + "", con);
                                    con.Open();
                                    cmd2.ExecuteNonQuery();
                                    con.Close();
                                    Console.WriteLine("Record updated successfully!!");
                                    break;

                                case 4:
                                    Console.WriteLine("Enter the product id to be searched");
                                    prod.p_id = int.Parse(Console.ReadLine());

                                    SqlDataAdapter dataadap = new SqlDataAdapter("select * from product", con);
                                    dataadap.Fill(ds, "products");
                                    int num = ds.Tables[1].Rows.Count;

                                  
                                    for (int j = 0; j < num; j++)
                                    {
                                        if (prod.p_id.ToString() == ds.Tables[1].Rows[j][0].ToString())
                                        {
                                            Console.WriteLine("Product name: " + ds.Tables["products"].Rows[j][1].ToString());
                                            Console.WriteLine("Product price: " + ds.Tables["products"].Rows[j][2].ToString());
                                            Console.WriteLine("Product quantity: " + ds.Tables["products"].Rows[j][3].ToString());
                                            Console.WriteLine("Category: " + Enum.GetName(typeof(categories), ds.Tables["products"].Rows[j][4]));
                                        }
                                        else
                                        {
                                            Console.WriteLine("Product id is not available");
                                        }
                                    }
                                       
                                        break;

                                case 5:
                                    Console.WriteLine("Enter the length of product name to be checked");
                                    prod.p_name = Console.ReadLine();

                                    SqlDataAdapter da2 = new SqlDataAdapter("select * from product", con);
                                    da2.Fill(ds, "products");
                                    int y = ds.Tables[1].Rows.Count;

                                    Predicate<string> lename = new Predicate<string>(prod.lenpname);

                                    for (int j = 0; j < y; j++)
                                    {
                                        if (lename.Invoke(ds.Tables["products"].Rows[j][1].ToString()))
                                        {
                                            Console.WriteLine("Product name: " + ds.Tables["products"].Rows[j][1].ToString());
                                            Console.WriteLine("Product price: " + ds.Tables["products"].Rows[j][2].ToString());
                                            Console.WriteLine("Product quantity: " + ds.Tables["products"].Rows[j][3].ToString());
                                            Console.WriteLine("Category: " + Enum.GetName(typeof(categories), ds.Tables["products"].Rows[j][4]));
                                            Console.WriteLine();
                                        }
                                    }

                                        break;
                                default:
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
}
