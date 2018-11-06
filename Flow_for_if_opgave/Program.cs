using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_for_if_opgave
{
    class Program
    {
        static void Main(string[] args)
        {




            for (int kolonne = 0; kolonne < 10; kolonne++)
            {


                for (int raekke = 0; raekke < 10; raekke++)
                {

                    string tal = (kolonne * raekke).ToString();


                    if (kolonne * raekke > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(tal.PadLeft(4));

                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }








            string value = Console.ReadLine();

        }
    }
}
