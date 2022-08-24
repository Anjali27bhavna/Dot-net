using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "Y";
            string name = "", roll_no = "", branch = "", mobile = "", email = "";
           
            for (; answer.ToUpper() == "Y";) 
            {
                Console.WriteLine("Press 1 to enter input ");
                Console.WriteLine("Press 2 to print the input");
                Console.WriteLine("Press 3 to check whether a number is palindrome or not");
                Console.WriteLine("Press 4 to check whether a number is armstrong or not");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter Student Name : ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter roll number : ");
                        roll_no = Console.ReadLine();
                        Console.WriteLine("Enter brach name");
                        branch = Console.ReadLine();
                        Console.WriteLine("Enter mobile number : ");
                        mobile= Console.ReadLine();
                        Console.WriteLine("Enter student's email : ");
                        email = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Name " + name);
                        Console.WriteLine("Roll no " + roll_no);
                        Console.WriteLine("Branch " + branch);
                        Console.WriteLine("Mobile " + mobile);
                        Console.WriteLine("Email " + email);
                        break;

                    case 3:
                        int p, r, sum = 0, temp;
                        Console.Write("Enter the Number: ");
                        p = int.Parse(Console.ReadLine());
                        temp = p;
                        while (p > 0)
                        {
                            r = p % 10;
                            sum = (sum * 10) + r;
                            p = p / 10;
                        }
                        if (temp == sum)
                            Console.Write("Number is Palindrome.");
                        else
                            Console.Write("Number is not Palindrome" );
                        break;

                    case 4:
                        int a, b, s = 0, count;
                        Console.Write("Enter the Number= ");
                        a = int.Parse(Console.ReadLine());
                        count = a;
                        while (a > 0)
                        {
                            b = a % 10;
                            s = s + (b * b * b);
                            a = a / 10;
                        }
                        if (count == s)
                            Console.Write("Armstrong Number.");
                        else
                            Console.Write("Not Armstrong Number.");
                        break;

                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                Console.WriteLine("Do you want to continue : Y/N");
                answer = Console.ReadLine();
            }
            
        }
    }
}
