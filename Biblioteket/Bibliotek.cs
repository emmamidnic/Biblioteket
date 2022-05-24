using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Bibliotek
    {

        private string _biblioteksNavn;

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        public string HentBibliotek()
        {
            
            return string.Format("Velkommen til {0} - Datoen i dag er: {1}", _biblioteksNavn, DateTime.Now);
        }


    }
}
