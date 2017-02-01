using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Television tv = new Television();

            tv.IsOn = true;
            tv.Volume = 50;
            tv.Channel = 120;
            tv.Singal();
            tv.DataPrint();
            tv.VolDown();
            tv.Channel = 160;
            tv.DataPrint();
            tv.Singal();

            
        }
    }
}
