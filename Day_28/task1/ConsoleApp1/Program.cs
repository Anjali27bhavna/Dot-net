using System;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=BHAVNAWKS636;database=employee;integrated security=true");

            
            employee emp = new employee();
            string myfile = @"C:\\Users\\Anjali.Saini\\Desktop\\Dot net\\Day_28\\task1\\output.txt";

            string isRepeat = "Y";

            while (isRepeat.ToUpper() == "Y")
            {
                Console.WriteLine("insertion");


                Console.WriteLine("Enter employee id : ");
                emp.id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name ");
                emp.name = Console.ReadLine();
                Console.WriteLine("Enter employee department ");
                emp.department = Console.ReadLine();
                Console.WriteLine("Enter employee salary ");
                emp.salary = Console.ReadLine();
                Console.WriteLine("Enter employee gender ");
                emp.gender = Console.ReadLine();

                SqlCommand cmd = new SqlCommand("insert into employee_info values(" + emp.id + ",'" + emp.name + "','" + emp.department + "','" + emp.salary + "','" + emp.gender + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("record inserted");
                

                if(!File.Exists(myfile))
                    using(StreamWriter sw = File.CreateText(myfile))
                    {
                        sw.WriteLine($"Record {i} : Id - {emp.id}, Name - {emp.name}, department - {emp.salary}, salary - {emp.salary}, gender - {emp.gender}");

                    }
                else
                    using(StreamWriter sw =File.AppendText(myfile))
                    {
                        sw.WriteLine($"Record : Id - {emp.id}, Name - {emp.name}, department - {emp.salary}, salary - {emp.salary}, gender - {emp.gender}");

                    }
                //reading the file
                using (StreamReader sr = File.OpenText(myfile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }

                Console.WriteLine("Do you want to continue Y/N");
                isRepeat = Console.ReadLine();
            }
            
            



            //FileStream f = new FileStream("C:\\Users\\Anjali.Saini\\Desktop\\output.txt", FileMode.Create);

            //StreamWriter s = new StreamWriter(f);
            //s.WriteLine("My name is anjali");

            //s.Close();
            //f.Close();

            //==============textwriter====================//

            //using (TextWriter writer = File.CreateText("C:\\Users\\Anjali.Saini\\Desktop\\writer.txt"))
            //{
            //    writer.WriteLine("Hello C#");
            //    writer.WriteLine("C# is a OOPS based programming language");
            //}

            //Console.WriteLine("Data written successfully");

            //using(BinaryWriter bw=new BinaryWriter(File.Open("C:\\Users\\Anjali.Saini\\Desktop\\binary.txt",FileMode.Create)))
            //{
            //    bw.Write(2.5);
            //    bw.Write("Manish Malhotra");
            //    bw.Write(true);
            //}

            //StringWriter str = new StringWriter();
            //str.WriteLine("Hello, I am from bhavnacorp");
            //str.Close();

            //StreamReader reader = new StreamReader(str.ToString());

        }
    }
}
