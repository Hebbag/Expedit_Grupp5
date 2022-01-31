using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Bokning 
    {
        public int ISBN { get; set; }
        public string Titel { get; set; }
        public int Medlemsnummer { get; set; }
        public DateTime TäUtlämningstid { get; set; }

        //public DateTime FaUtlämningstid { get; set; } //behövs denna här tro
        public DateTime TäÅterlämningstid { get; set; }
        public int Anställningnummer { get; set; }
        public int Bokningsnummer { get; set; }

        public Bokning(List<Bok> böcker, int isbn, string titel, int mnr, DateTime täut, DateTime täåt, int ansnr, int boknr)
        {
            böcker = new List<Bok>();
            ISBN = isbn;
            Titel = titel;
            Medlemsnummer = mnr;
            TäUtlämningstid = täut;
            TäÅterlämningstid = täåt;
            Anställningnummer = ansnr;
            Bokningsnummer = boknr;

        }

    }
}
