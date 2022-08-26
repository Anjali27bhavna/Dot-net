using System;

namespace customer
{
    public class customerinfo : Icustomer
    {
        
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public long MobileNumber { get; set; }
            public string CustomerAddress { get; set; }

        public void display()
        {
            Console.WriteLine("Enter CustomerId");
            CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CustomerName");
            CustomerName = Console.ReadLine();
            Console.WriteLine("Enter MobileNumber");
            MobileNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter CustomerAddress");
            CustomerAddress = Console.ReadLine();
            Console.WriteLine("CustomerId is : " + CustomerId + " " +  "CustomerName is : "+ CustomerName + " " + "MobileNumber is : " + MobileNumber + " " + "CustomerAddress is : " + CustomerAddress);
        }
    }
}
