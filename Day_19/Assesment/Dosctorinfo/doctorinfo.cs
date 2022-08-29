using System;

namespace Doctor
{
    public class doctorinfo
    {
        public int docid { get; set; }
        public string docname { get; set; }
        public string docdept { get; set; }

    public void docdisplay()
        {
         
                Console.WriteLine("Enter the doc id : ");
                docid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the doctor name : ");
                docname = Console.ReadLine();
                Console.WriteLine("Enter the department : ");
                docdept = Console.ReadLine();
            Console.WriteLine("Doc name : " + docid +" Doc name : "+docname+" Doc department : "+docdept);
            
        }
    }
}
