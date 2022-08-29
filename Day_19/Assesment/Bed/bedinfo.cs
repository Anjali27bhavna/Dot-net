using System;

namespace Bed
{
    public class bedinfo : Ibed
    {
        public int roomno { get; set; }
        public string room_type { get; set; }
        public int floorno { get; set; }
        public int blockno { get; set; }
        public void bedshow()
        {
            Console.WriteLine("Enter the room number : ");
            roomno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the room type : ");
            room_type = Console.ReadLine();
            Console.WriteLine("Enter the floorno : ");
            floorno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the block number : ");
            blockno = int.Parse(Console.ReadLine());

            Console.WriteLine("Room no : " + roomno + " Room type : " + room_type + " Floor no : " + floorno + " Block no : " + blockno);
        }
    }
}
