using System;

namespace studentproject
{
    public class item
    {
        ///public int sum(int x, int y)
        ///{
        ///    return x + y;
        ///}

        public string items { get; set; }

        public void show()
        {
            Console.WriteLine("Product " + items);
        }
    }
}
