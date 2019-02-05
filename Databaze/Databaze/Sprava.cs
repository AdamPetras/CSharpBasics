using System.Collections.Generic;

namespace Databaze
{
    public class Sprava
    {
        private List<Databaze> db;
        private Databaze databaze;

        public Sprava()
        {
            db = new List<Databaze>();
        }

        public void Add(string jmeno,int datumVydani,string nakladatelstvi)
        {
            databaze =new Databaze(jmeno,datumVydani,nakladatelstvi);
            db.Add(databaze);
        }

        public void Delete(int index)
        {
            db.RemoveAt(index);
        }

        public int GetDbLength()
        {
            return db.Count;
        }

        public Databaze GetDbIndex(int index)
        {
            return db[index];
        }
    }
}
