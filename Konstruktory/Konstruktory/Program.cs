using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    internal class Program
    {
        static string jméno;
        static Program()
        {
        jméno = "Honza";
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(jméno);
        }
    }
}
