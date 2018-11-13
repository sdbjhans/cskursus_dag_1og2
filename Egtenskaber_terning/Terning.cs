using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egtenskaber_terning
{
    public class Terning
    {

        private static System.Random rnd = new Random();


        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                if (value< 0 || value >6)
                {
                    value = 1;
                }
                værdi = value; }
        }


        public Terning()

        {
            this.Ryst();

        }



        public void Ryst()
        {
            this.Værdi = rnd.Next(1,7);
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

    }
}
