namespace Databaze
{
    public class Databaze
    {
        public string Jmeno { get; private set; }
        public int DatumVydani { get; private set; }
        public string Nakladatelstvi { get; private set; }

        public Databaze(string  jmeno,int datumVydani,string nakladatelstvi)
        {
            Jmeno = jmeno;
            DatumVydani = datumVydani;
            Nakladatelstvi = nakladatelstvi;
        }

        public override string ToString()
        {
            return Jmeno + "\n" + DatumVydani + "\n" + Nakladatelstvi;
        }
    }
}
