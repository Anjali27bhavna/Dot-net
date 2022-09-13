using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class product
    {
        public int prod_id { get; set; }
        public string prod_name { get; set; }
        public int prod_price { get; set; }

        public static int totalrepair(int man,int pro)
        {
            return man + pro;
        }
    }
}
