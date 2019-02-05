using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    struct Pozice   //struktura pozice
    {
        public int X;
        public int Y;

        public Pozice(int X, int Y) //konstuktor struktury
        {
            this.X = X;
            this.Y = Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pozice pozice;  //definujeme bez operátoru new, který u struktur nefunguje --> Pozice pozice =NEW!! Pozice()
            pozice.X = 0;
            pozice.Y = 0;   //--> pokud budou nainicializovany všechny prvky tak se jedná o plně inicializovanou strukturu
            pozice.X++;
            Console.WriteLine(pozice.X);
        }
    }
}
