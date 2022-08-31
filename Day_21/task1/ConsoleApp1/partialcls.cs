using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class gfg1
    {
        private string Author_name;
        private int total_articles;

        public gfg1(string a, int t)
        {
            this.Author_name = a;
            this.total_articles = t;

        }
    }
    public partial class gfg1
    {
        public void display()
        {
            Console.WriteLine("author name is : " + Author_name);
            Console.WriteLine("total number of articles : " + total_articles);
        }
    }
}
