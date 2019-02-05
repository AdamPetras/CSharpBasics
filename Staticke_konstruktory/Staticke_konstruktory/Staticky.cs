using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticke_konstruktory
{
    class Staticky
    {
        static Staticky()   //statický konstruktor nemá přijímat žádné parametry a nemůže být v jedné třídě více jak jeden krát
        {
            Console.WriteLine("Statický konstruktor");
        }
    }
}
