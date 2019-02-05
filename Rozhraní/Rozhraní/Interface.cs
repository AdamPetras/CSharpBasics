using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhraní
{
    class Interface :IUzivatel
    {
        private float stav;   //nadefinování operační hodnoty se kterou pracujeme
        public void Prijmy(float prijmy)        //počáteční peníze
        {
            stav += prijmy;
        }

        public float Placeni(float prijmy)      //placení
        {
            if (stav > prijmy)
                stav -= prijmy;
            return stav;
        }

        public void Vypis()     //výpis hodnot
        {
            Console.Write(Stav);
        }
        public float Stav {       //vrácení hodnot stavu
            get { return stav; }
        }
    }
}
