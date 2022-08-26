using System;

namespace products
{
        public class productinfo : Iprod
        {
            public int ProdId { get; set; }
            public string item { get; set; }
            public int price { get; set; }
            public int quantity { get; set; }

            public void show()
            {
                Console.WriteLine("Enter product id: ");
                ProdId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter item name: ");
                item = Console.ReadLine();
                Console.WriteLine("Enter price: ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter quantity: ");
                quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Product id is : " + ProdId + " " + "Item name is : " + item + " " + "Price is: " + price + " " + "Product Quantity is : " + quantity);
            }
        }
}
