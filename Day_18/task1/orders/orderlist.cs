using System;

namespace orders
{
    public class orderlist : Iorder
    {
        int orderid { get; set; }
        string orderAddress { get; set; }
        public void orderdetails()
        {
            Console.WriteLine("Enter Order id");
            orderid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Address");
            orderAddress = Console.ReadLine();
            Console.WriteLine("Order id is : " + orderid + " " + "Order address is : " + orderAddress);
        }
    }
}
