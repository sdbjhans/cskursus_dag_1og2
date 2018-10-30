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

            int kolonne = 0;
            int række = 0;

            for (int h = 0; h < 10; h++)
            {
                række++;

                for (int v = 0; v < 10; v++)
                {
                    kolonne++;
                    int tal = kolonne * række;
                    Console.Write(tal+"\t");

                    if (tal > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                }
                kolonne = 0;
                Console.WriteLine("\r\n");
            }

            

            
            række++;



            string value = Console.ReadLine();

        }
    }
}
