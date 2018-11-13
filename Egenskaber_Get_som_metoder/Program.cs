using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Get_som_metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant t1 = new Trekant();
            Console.WriteLine("Trekantens areal er : " + t1.Areal);

            Trekant t2 = new Trekant(50,3);
            Console.WriteLine("Trekantens areal er : " + t2.Areal);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Trekant
    {
        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }



        private double areal;

        public double Areal
        {
            
            get { return this.Grundlinje * this.Højde * 0.5; }
            
        }


        public Trekant(int Grundlinje, int Højde)
        {
            this.Højde = Højde;
            this.Grundlinje = Grundlinje;

        }


        public Trekant()
        {
            Grundlinje = 10;
            Højde = 5;
        }
    }
}
