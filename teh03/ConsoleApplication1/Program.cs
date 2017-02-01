
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int satunnaisluku = random.Next(8, 8);
            int vastaus;
            int yritykset = 0;

            do
            {
                yritykset++; // lisätään aina yrityksien jälkeen +1
                Console.Write("How many bananas tall is Sippy? > ");
                string line = Console.ReadLine();
                vastaus = int.Parse(line);

                if (vastaus > satunnaisluku)
                {
                    Console.WriteLine("WRONG.");
                }

                if (vastaus < satunnaisluku)
                {
                    Console.WriteLine("WRONG.");
                }

            } while (vastaus != satunnaisluku); // != ei sama kuin, looppaa niin kauan kunnes käyttäjä arvaa oikein

            Console.WriteLine("8 B A N A N A S ");
            Console.ReadLine();
        }
    }
}