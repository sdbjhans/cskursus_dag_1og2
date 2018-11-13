using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Terning
{
    class Terning
    {
        //Menbers:
        public int værdi;
        private bool snyd;
        private static System.Random rnd = new System.Random();



        //Default constructor:

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }

        // Custom Constructor
        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }

        //Methoder:
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");

        }

        public void Ryst()
        {
        if (snyd)
            this.værdi = 6;

            else
             this.værdi = rnd.Next(1,7);
        }
         

    }
}

