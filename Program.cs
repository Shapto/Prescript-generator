using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Prescript_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Begin:
            {
                string output = Prescripts.newPrescriptText();
                if (output.Length < 200)
                    Console.WriteLine(output);
                else
                    Console.WriteLine("FAILURE");
                    Console.WriteLine("GET NEW PRESCRIPT?");
            }
            Console.ReadKey();
            goto Begin;
        }
    }
}
