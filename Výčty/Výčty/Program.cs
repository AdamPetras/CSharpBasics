using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Výčty
{
    class Program
    {
        public enum dny
        {         
            Pondeli=1,
            Utery=2,
            Streda=3,
            Ctvrtek=4,
            Patek=5,
            Sobota=6,
            Nedela=7
        }
        static void Main(string[] args)
        {
            dny den = new dny();
            Console.WriteLine(dny.Pondeli);
            Console.WriteLine(dny.Utery);
            Console.WriteLine(dny.Streda);
            Console.WriteLine(dny.Ctvrtek);
            Console.WriteLine(dny.Patek);
            Console.WriteLine(dny.Sobota);
            Console.WriteLine(dny.Nedela);
            if (den==dny.Pondeli)
                Console.WriteLine(dny.Pondeli);
        }
    }
}
