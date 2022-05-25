using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Bibliotek
    {

        private Laaner _laaner;
        private string _biblioteksNavn;

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        public string HentBibliotek()
        {
            
            return string.Format("Velkommen til {0} - Datoen i dag er: {1}", _biblioteksNavn, DateTime.Now);
        }

        public Laaner OpretLaaner(int laanerNummer, string fornavn, string efternavn)
        {
            _laaner = new Laaner(laanerNummer, fornavn, efternavn);
            return _laaner;
                         
        }

        public string HentLaaner()
        {
            return string.Format("Lånernummer: {0} \nNavn: {1} \nEr låner hos: {2}", _laaner.LaanerNummer, _laaner.FuldeNavn, _biblioteksNavn);
        }


    }
}
