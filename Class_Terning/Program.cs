using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uden snyd
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            //med snyd, der kun slår 6´ere..
            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            //Uden snyd
            Terning t3 = new Terning();
            t3.Skriv();
            t3.Ryst();
            t3.Skriv();


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
