using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Fornavn = "Andrea";
            p1.Efternavn = "Hansen";
            p1.Fødselsår = 2003;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());


            Person p2 = new Person("Jakob","Hansen",2001);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            Console.ReadLine();

        }
    }

    class Person
    {
        //Members:
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;


        //Methoder:
        public string FuldtNavn()
        {

            return $"{Fornavn}  {Efternavn}";
        }

        public int EstimeretAlder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        //Default constructor
        public Person()
        {
            Fornavn = "";
            Efternavn = "";
        }

        //Custom Constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Fødselsår = fødselsår;

        }
    }


}
