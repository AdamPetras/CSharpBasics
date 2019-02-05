using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string cesta = "";
            try
            {
                cesta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "C#_tutoriál");
                if (!Directory.Exists(cesta))
                    Directory.CreateDirectory(cesta);
                    text_soubor();
                    using (StreamReader sr = new StreamReader(@"soubor.txt"))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
            }
            catch
            {
                Console.WriteLine("Nepodařilo se vytvořit složku {0}, zkontrolujte prosím svá oprávnění.", cesta);
            }
            if (File.Exists(Path.Combine(cesta, "databaze.dat")))
            {
                try
                {
                    // Zde umístěte kód pro načtení vašeho nastavení ze souboru
                }
                catch (Exception e)
                {
                    Console.WriteLine("Při načítání nastavení došlo k následující chybě: {0}", e.Message);
                }
            }
            else
            {
                try
                {
                    // Zde umístěte kód pro vytvoření vašeho nastavení ze souboru
                }
                catch (Exception e)
                {
                    Console.WriteLine("Při vytvoření nastavení došlo k následující chybě: {0}", e.Message);
                }
            }
        }

        private static void text_soubor()
        {
            using (StreamWriter sw = new StreamWriter(@"soubor.txt"))
            {
                sw.WriteLine("První řádek");
                sw.WriteLine("Tento text je na druhém řádku");
                sw.WriteLine("A do třetice.");
                sw.Flush();
            }
        }
    }
}

