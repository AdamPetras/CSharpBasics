using System;

namespace Databaze
{
    class Program
    {
        private static void Main(string[] args)
        {

            Sprava sprava = new Sprava();
            ConsoleKeyInfo key;
            do
            {
                WriteMenu();
                key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.NumPad1:
                    {                                          
                        sprava.Add(Jmeno(),DatumVydani(),Nakladatelstvi());
                        break;
                    }
                    case ConsoleKey.NumPad2:
                    {
                        Console.WriteLine("Zadej index");
                        try
                        {
                            Console.WriteLine(sprava.GetDbIndex(Convert.ToInt32(Console.ReadLine()) + 1));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Zadal jsi špatný index");
                            WriteMenu();                         
                        }
                        break;
                    }
                    case ConsoleKey.NumPad3:
                    {
                        if (sprava.GetDbLength()!=0)
                        {
                            for (int i = 0; i <= sprava.GetDbLength() - 1; i++)
                                Console.WriteLine(sprava.GetDbIndex(i));
                        }
                        else
                        {
                            Console.WriteLine("Databaze je prazdna");
                        }
                        break;
                    }
                    case ConsoleKey.NumPad4:
                    {
                        Console.WriteLine("Zadej index");
                        try
                        {
                            sprava.Delete(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Zadal jsi špatný index");
                            WriteMenu();
                        }
                        break;
                    }                       
                }            
        } while (key.Key != ConsoleKey.NumPad5);
        }

        public static string Jmeno()
        {
            Console.WriteLine("Zadej jmeno");
            return Console.ReadLine();
        }
        public static int DatumVydani()
        {
            Console.WriteLine("Zadej datum vydání");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string Nakladatelstvi()
        {
            Console.WriteLine("Zadej nakladatelství");
            return Console.ReadLine();
        }

        public static void WriteMenu()
        {
            Console.WriteLine("[1]-Add\n[2]-Get\n[3]-Get all\n[4]-Remove\n[5]-End\n");
        }
    }
}
