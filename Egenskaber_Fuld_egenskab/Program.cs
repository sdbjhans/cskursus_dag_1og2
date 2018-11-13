using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Fuld_egenskab
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Navn = "Vare #1";
            v.Pris = 120;

            Console.WriteLine(v.Pris);
            Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("Vare #2", 150);
            Console.WriteLine(v2.PrisMedMoms());


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
