using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal_opgave
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;

            heltal++;

            heltal--;

            heltal += 20;

            Console.WriteLine($"Heltal = {heltal}");

            double kommatal = 12.5;

            kommatal++;

            kommatal--;

            kommatal *= 20;

            Console.WriteLine($"Kommatal = {kommatal}");

            Console.ReadKey();
            
        }
    }
}
