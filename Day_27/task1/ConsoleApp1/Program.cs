using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("Reflection.MethodInfo");
            // Gets and displays the Type.
            Type myType = Type.GetType("System.Reflection.FieldInfo");
            // Specifies the member for which you want type information.
            MethodInfo myMethodInfo = myType.GetMethod("GetValue");
            Console.WriteLine(myType.FullName + "." + myMethodInfo.Name);
            // Gets and displays the MemberType property.
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine(MemberTypes.Constructor);
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine(myMemberTypes);
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
            return 0;

            //Assembly info = typeof(int).Assembly;
            //Console.WriteLine(info);      //type and assembly of the data using refelection

            //Type t = typeof(System.String);
            //Console.WriteLine("Listing all the public constructors of {0} type", t);
            //ConstructorInfo[] ci = t.GetConstructors(BindingFlags.Public);
            //Console.WriteLine("Constructors are : ");
            //PrintMenbers(ci);
        }
        //public static void PrintMenbers(ConstructorInfo[] c)
        //{
        //    foreach (ConstructorInfo a in c)
        //        Console.WriteLine("", "           ", a);
        //}
        
    }
}
