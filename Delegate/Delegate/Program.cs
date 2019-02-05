using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateMathOperation metoda = new MathOperations().Nasobit;
            Console.WriteLine(metoda(10, 20));

            DelegateMathOperation[] listMetod = 
            {
             new MathOperations().Nasobit,
            new MathOperations().Soucet,
            new MathOperations().Odecist,
            new MathOperations().Delit};
            for (int i = 0; i <= listMetod.Length - 1; i++)
                Console.WriteLine(listMetod[i](20, 10));
        }
    }
}