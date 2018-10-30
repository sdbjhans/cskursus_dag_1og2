using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_text_opgave
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn +" " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string forkortetNavn = samletNavn.Substring(7, 4);

            Console.WriteLine(fornavn + "\t" + efternavn + "\r\n" + samletNavn + "\t" + navnStort + "\t" + navnLille + "\t" + forkortetNavn);


            System.IO.File.WriteAllText(@"C:\temp\minfil.txt",samletNavn);

            Console.ReadLine();
        }
    }
}
