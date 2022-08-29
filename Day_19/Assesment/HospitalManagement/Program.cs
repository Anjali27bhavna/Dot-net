using System;
using Doctor;
using Patient;
using Bed;

namespace HospitalManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string anw = "Y";
            for (; anw.ToUpper() == "Y";)
            {
                Console.WriteLine("Press 1 for Doctor info");
                Console.WriteLine("Press 2 for Patient info");
                Console.WriteLine("Press 3 for bed details");

                int n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 1:
                        doctorinfo dinfo = new doctorinfo();
                        dinfo.docdisplay();
                        break;
                    case 2:
                        patientinfo pat = new patientinfo();
                        pat.patientdisplay();
                        break;
                    case 3:
                        bedinfo bed = new bedinfo();
                        bed.bedshow();
                        break;
                }
                Console.WriteLine("Do you want to continue : Y/N");
                anw = Console.ReadLine();
            }
        }
    }
}
