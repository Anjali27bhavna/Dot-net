using System;

namespace Patient
{
    public class patientinfo:Ipatient
    {
        public int patientid { get; set; }
        public string patientname { get; set; }
        public string email { get; set; }
        public int age { get; set; }

        public void patientdisplay()
        {
            Console.WriteLine("Enter patient id : ");
            patientid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter patient name : ");
            patientname = Console.ReadLine();
            Console.WriteLine("Enter patient emailid : ");
            email = Console.ReadLine();
            Console.WriteLine("Enter patients age : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Patient id : "+patientid+" Patient name : "+patientname+" Patient email : "+patientid+" Patient age : "+age)
        }
    }
}
