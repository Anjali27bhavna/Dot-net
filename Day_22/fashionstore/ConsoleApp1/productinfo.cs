using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class productinfo:Isample
    {
        public int p_id { get; set; }
        public string p_name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int c_id { get; set; }

        public bool lenpname(string name)
        {
            if (name.Length > 6)
                return true;
            return false;
        }
    }
}
