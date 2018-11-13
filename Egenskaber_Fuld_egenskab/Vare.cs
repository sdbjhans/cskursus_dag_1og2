using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Fuld_egenskab
{
    class Vare
    {

        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this.navn = navn;
            this.pris = pris;

        }

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set {
                Console.WriteLine("Nu sættes pris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            
            return this.pris * 1.25;
        }

    }
}
