using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Television
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        
        public  void VolUp ()

        {
            Volume += 1;
        }

        public void VolDown()
        {
            Volume -= 1;
        }
        public void Singal()
        {
            if (Channel > 150)
            {
                Console.WriteLine("Signal lost");
            }
        }
            public void DataPrint()
        {
            Console.WriteLine("Power on:" + IsOn);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Volume: " + Volume);
        }
    }

    }

