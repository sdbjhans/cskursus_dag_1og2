using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_struct_enum
{
    partial class Program
    {
        static void Main(string[] args)
        {

            FilTyper ft = FilTyper.csv;

            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);

            string value = Console.ReadLine();
        }
    }
}
