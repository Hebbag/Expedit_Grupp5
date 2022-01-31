using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class BokRepository
    {
        private List<Bok> bok = new List<Bok>();

        public List<Bok> böcker()
        {
            if (bok.Count == 0)
            {
                bok.Add(new Bok(1, "Test avIT-system", true));
                bok.Add(new Bok(2, "Harry Potter", true));
                bok.Add(new Bok(3, "Lejonkungen", true));
                bok.Add(new Bok(4, "Byggare Bob och katten", true));
                bok.Add(new Bok(5, "Laverne and the muppet", true));
                bok.Add(new Bok(6, "Din feta lilla gris", true));
                bok.Add(new Bok(7, "Pippi Långstrump", true));
                bok.Add(new Bok(8, "Kalle och chokladfabriken", true));
                bok.Add(new Bok(9, "Jenna Jameson, how to be an actress", true));
                bok.Add(new Bok(10, "Reddit, the true story", true));
                bok.Add(new Bok(11, "La-la-land", true));
                bok.Add(new Bok(12, "Teletubbies", true));
                bok.Add(new Bok(13, "Tunnan och moroten", true));
                bok.Add(new Bok(14, "The bible", true));



            }
            return bok;
        }
    }
}
