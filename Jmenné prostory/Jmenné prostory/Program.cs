using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ukoly.doCsharp.ze_skoly;
using ukoly.doMatiky.ze_skoly;
using lol=ukoly.doCsharp.ze_skoly;

namespace ukoly.doMatiky.ze_skoly
{
    class Namespace
    {
        
    }

}
namespace ukoly.doCsharp.ze_skoly
{
    class Namespace
    {
        public static int nic()
        {
            ze_skoly.Namespace csharp = new ze_skoly.Namespace();
            Console.WriteLine(csharp.GetType());
            return 0;
        }
    }


}
namespace Jmenné_prostory
{
    class Program
    {  
        static void Main(string[] args)
        {
            ukoly.doCsharp.ze_skoly.Namespace csharp = new ukoly.doCsharp.ze_skoly.Namespace();
            Console.WriteLine(csharp.GetType());
            lol.Namespace Toto_je_alias = new lol.Namespace();
        }
    }
}
