using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
                      

            DateTime d1 = DateTime.Now;

            Console.WriteLine("Datoen er nu :" + d1);

            d1 = d1.AddDays(10);

            Console.WriteLine("Datoen er nu :" + d1);

            d1 = d1.AddMinutes(20);

            Console.WriteLine("Datoen er nu :"+ d1);

            d1 = d1.AddMonths(-1);

            Console.WriteLine("Datoen er nu :"+ d1);

            DateTime d2 = new DateTime(2018, 10, 30);
            DateTime d3 = new DateTime(2018, 11, 30);
            TimeSpan t1 = d3.Subtract(d2);
        
            Console.WriteLine("Forskellen er :" + t1.Days + " Dage" );

            TimeSpan t2 = new TimeSpan(16, 0, 0);

            Console.WriteLine("Timespan t2 er lig med : " + t2);

            TimeSpan t3 = new TimeSpan(0, 30, 0);

            Console.WriteLine("Timespan t3 er lig med : " + t3);

            TimeSpan t4 = t2-t3;
            //kan også skrives sådan her
            //TimeSpan t4 = t2.Subtract(t3);




            Console.WriteLine("Timespan t4 er lig med : " + t4);

            TimeSpan t5 = t2 + t3;
            //kan også skrives sådan her :
            //TimeSpan t5 = t2.Add(t3);

            Console.WriteLine("Timespan t5 er lig med : " + t5);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
