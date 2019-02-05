using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticke_konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text");
            Staticky staticky = new Staticky(); //statický konstruktor se vykoná pouze jednou názorný příklad o 2 řádky níže
            Console.WriteLine("Konec");
            Staticky s1=new Staticky(); //již se nic nevypíše
            
        }
    }
}
