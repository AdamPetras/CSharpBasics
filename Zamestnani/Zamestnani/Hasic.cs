using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnani
{
    class Hasic:Clovek,IReturn
    {
        public Hasic(string jmeno,string prijmeni,int vek):base(jmeno,prijmeni,vek)
        {
        }
        public string RetJmeno()
        {
            return jmeno;
        }

        public string RetPrijmeni()
        {
            return prijmeni;
        }

        public int RetVek()
        {
            return vek;
        }

    }
}
