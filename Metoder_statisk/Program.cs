using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_statisk
{
    class Program
    {
        static void Main(string[] args)
        {

            bool t = System.IO.File.Exists(@"c:\temp\test.txt");
            Console.WriteLine($"Findes fil: {t}");

            string text = System.IO.File.ReadAllText(@"c:\temp\test.txt");
            Console.WriteLine(text);
                
            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            DateTime d = fil.LastAccessTime;

            Console.ReadLine();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
}
