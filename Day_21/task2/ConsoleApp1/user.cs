using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class user
    {
        //declare an array
        private string[] arr = new string[3];

        //define an indexer for class
        public string this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
}
