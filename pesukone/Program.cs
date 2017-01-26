using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
                Pesukone pesukone = new Pesukone();
                pesukone.OnkoPäällä = true;
                pesukone.Pikapesu = true;
                pesukone.Linkous = 50;
                pesukone.Lämpötila = 90;
            Console.WriteLine("Linkous on " + pesukone.Linkous);
            Console.WriteLine("Lämpötila on " + pesukone.Lämpötila);
        }
    }
}
