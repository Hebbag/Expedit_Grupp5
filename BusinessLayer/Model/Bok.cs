using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Bok 
    {
        public int ISBN { get; private set; }
        public string Titel { get; private set; }

        public int Dagar { get; private set; }

        private List<Bokning> BokningList;


        internal Bok(int isbn, string titel, bool v)
        {
            ISBN = isbn;
            Titel = titel;
            Dagar = 7;
            BokningList = new List<Bokning>();
        
        }


    }
}
