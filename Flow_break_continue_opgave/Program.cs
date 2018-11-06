using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow_break_continue_opgave
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 19; i++)
            {
                if (i % 3 != 0)
                    continue;



                if (i > 15)
                    break;



                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
