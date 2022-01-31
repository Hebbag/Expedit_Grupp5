using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Faktura
    {
        public int Bokningsnummer { get; set; }
        public DateTime FaUtlämningstid { get; set; }
        public DateTime FaÅterlämningstid { get; set; }
        public int Totalpris { get; set; }

        public Faktura(int boknr, DateTime faut, DateTime faåt, int total)
        {
            Bokningsnummer = boknr;
            FaUtlämningstid = faut;
            FaÅterlämningstid = faåt;
            Totalpris = total;

        }
    }
}
