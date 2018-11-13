using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber_Automatisk_egenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            // En måde at generere en ny person:

            Person p = new Person();
            p.Fornavn = "Jan";
            p.Efternavn = "Hansen";
            Console.WriteLine(p.Fuldtnavn());



            // En simplere måde at generere en ny person:

            Person p1 = new Person() {Fornavn = "Jan", Efternavn ="Hansen"};
            Console.WriteLine(p1.Fuldtnavn());


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
    }

    class Person
    {
        public string Fornavn { get; set; }



        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {

                if (value.Length < 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }

            }
        }

        public String Fuldtnavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }



}
