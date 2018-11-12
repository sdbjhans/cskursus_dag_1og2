﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejlhåndtering_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Det indtatsede er ikke et tal" + ex.Message );

                prøvIgen();
                //throw;
            }

        }
        private static void Run()
        {
            Console.WriteLine("indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            int res = tal1 + tal2;
            Console.WriteLine("resultatet er" + res);

            

            
        }

        static void prøvIgen()
        {
            int prøvAntalGange = 3;
            int antal = 0;
            while (antal < prøvAntalGange)
            {
                try
                {
                    Run();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Der er sket en fejl" + ex.Message);
                    antal++;
                }

            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
