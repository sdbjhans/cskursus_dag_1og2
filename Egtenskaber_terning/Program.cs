using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egtenskaber_terning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t = new Terning();

            t.Skriv();
            t.Ryst();
            t.Skriv();

            t.Værdi = 7;
            t.Skriv();

            t = new Terning(6);
            t.Skriv();


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
    }
}
