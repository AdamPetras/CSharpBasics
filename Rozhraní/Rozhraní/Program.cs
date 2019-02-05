using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhraní
{
    public interface IUzivatel      //vytvoření vlastního rozhraní
    {
        void Prijmy(float prijmy);
        float Placeni(float placeni);
        void Vypis();
        float Stav {get;}
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IUzivatel interf = new Interface();     //Vytvoření objektu rozhraní
            interf.Prijmy(100);
            interf.Placeni(25);
            interf.Vypis();
            Console.WriteLine("");
            IUzivatel[] intf = new Interface[3];    //Vytvoření objektu pole-rozhraní
            intf[0]=new Interface();
            intf[1] = new Interface();
            intf[2] = new Interface();
            intf[0].Prijmy(250);
            intf[0].Placeni(120);
            intf[0].Vypis();
            Console.WriteLine("");
            intf[1].Prijmy(200);
            intf[1].Placeni(160);
            intf[1].Vypis();
            Console.WriteLine("");
            intf[2].Prijmy(500);
            intf[2].Placeni(320);
            intf[2].Vypis();
            Console.WriteLine("");
        }     
    }
}
