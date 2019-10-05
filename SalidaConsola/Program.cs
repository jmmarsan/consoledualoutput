using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalidaConsola
{
    class Program
    {
        static void Main(string[] args)
        {


            var dualOutput = new ConsoleFileOutput(@"consoleout.txt", Console.Out);
            Console.SetOut(dualOutput);
            

            for (int i = 1; i < 100000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
