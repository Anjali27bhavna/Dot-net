using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.App
{
    class Entry
    {
        static void Main(string[] args)
        {
            
            ATMApp atmApp = new ATMApp();
            atmApp.IntializeData();
            atmApp.Run();
            
        }
    }
}
