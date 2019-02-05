using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate double DelegateMathOperation(int x,int y);
    public class MathOperations
    {
        public double Soucet(int x, int y)
        {
            return x + y;
        }

        public double Odecist(int x, int y)
        {
            return x - y;
        }
        public double Nasobit(int x, int y)
        {
            return x * y;
        }
        public double Delit(int x, int y) 
        {
            double vysledek = 0;
            if (y!=0)
            vysledek = x / y;
            return vysledek;
        }
    }
}
