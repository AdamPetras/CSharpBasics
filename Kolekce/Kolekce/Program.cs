using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekce
{
    class Program
    {                  
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(10);
            list.Add(3);
            list.Add(20);
            foreach (int i in list)
                Console.WriteLine(i);
            Console.WriteLine(list.Count);
            Console.WriteLine("#############################################");
            // inicializace a naplnění spojového seznamu
            LinkedList<int> seznam = new LinkedList<int>();
            seznam.AddLast(1);
            seznam.AddLast(2);
            LinkedListNode<int> prostredni = seznam.AddLast(3);
            seznam.AddLast(4);
            seznam.AddLast(5);

            // přidávání a mazání v prostředku seznamu
            seznam.AddAfter(prostredni, 32);
            seznam.AddAfter(prostredni, 31);
            seznam.Remove(prostredni);

            // výpis seznamu
            foreach (int i in seznam)
                Console.Write("{0}, ", i);

            Console.ReadKey();
        }
    }
}
