using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnani
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozarnik poz = new Pozarnik("Adam","Petras",18);
            Console.WriteLine(poz.RetJmeno()+poz.RetPrijmeni()+poz.RetVek());
        }
    }
}
