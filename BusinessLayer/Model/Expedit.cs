using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    public class Expedit
    {
        public int Anställningsnummer { get; set; }
        public string ExNamn { get; set; }
        public string Lösenord { get; set; }
        public string Roll { get; set; }


        public Expedit(int ansnr, string namn, string lösen, string roll)
        {
            Anställningsnummer = ansnr;
            ExNamn = namn;
            Lösenord = lösen;
            Roll = roll;


        }

        //public bool LogIn(string employeeID, string password)
        //{
        //    //foreach (Expedit clerk in repoClerk.GetClerks())
        //    //{
        //    //    if (clerk.ExNamn == employeeID && clerk.VerifyPassword(password))
        //    //    {
        //    //        Inloggad = clerk;
        //    //        return true;
        //    //    }

        //    //}
        //    //Inloggad = null;
        //    //return false;
        //}
        internal bool VerifyPassword(string enter)
        {
            return Lösenord == enter;
        }
    }
}
