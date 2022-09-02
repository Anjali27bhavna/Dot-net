using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public class complex
        {
            private int x;
            private int y;
            public complex()
            {

            }
            public complex(int i, int j)
            {
                x = i;
                y = j;
            }
            public void show()
            {
                Console.WriteLine(x + "/" + y);
            }
            public static complex operator -(complex c)
            {
                complex temp = new complex();
                temp.x = -c.x;
                temp.y = -c.y;
                return temp;
            }
        }
        public class person
        {
            public int age;
        }
        public static void square(person a, person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }


    }
}
