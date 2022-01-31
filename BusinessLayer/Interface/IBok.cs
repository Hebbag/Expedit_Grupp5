using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Model;

namespace BusinessLayer.Interface
{
    public interface IBok
    {
        List<Bok> böcker();
        List<Bokning> BokningList();

        //List<Bok> FillBooks();
        //List<Bok> GetBooks();
        //Bok TempBook(string s);
        //void MarkAsUnavailable(List<Bok> _books);
        //void MarkAsAavailable(List<Bok> _books);

    }
}
