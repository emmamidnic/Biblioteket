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
        private List<Laaner> laanere = new List<Laaner>();

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        public string HentBibliotek()
        {
            
            return string.Format("Velkommen til {0} - Datoen i dag er: {1}", _biblioteksNavn, DateTime.Now);
        }

        public string OpretLaaner(int laanerNummer, string fornavn, string efternavn)
        {
            _laaner = new Laaner(laanerNummer, fornavn, efternavn);
            laanere.Add(_laaner);
            return string.Format("Bruger oprettet:\nNavn: {0}\nLånernummer: {1}\n\n", fornavn + " " + efternavn, laanerNummer);
        }

        public string HentLaaner()
        {
            return string.Format("\n\nLånernummer: {0} \nNavn: {1} \nEr låner hos: {2}", _laaner.LaanerNummer, _laaner.FuldeNavn, _biblioteksNavn);
        }

        public string HentAlleLaanere()
        {
            string result = "";

            foreach(Laaner l in laanere)
            {
                result += string.Format("Navn: {0} {1} - Lånernummer: {2}\n", l.Fornavn, l.Efternavn, l.LaanerNummer);
            }

            return result;
        }


    }
}
