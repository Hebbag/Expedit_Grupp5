using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public  class Medlem
    {
        public int Medlemsnummer { get; set; }
        public string MeNamn { get; set; }
        public int Telefonnummer { get; set; }
        public string Epost { get; set; }


        public Medlem()
        {

        }
    }
}
