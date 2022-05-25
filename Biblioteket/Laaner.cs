using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner
    {
        private int _laanerNummer;
        private string _fornavn;
        private string _efternavn;

        public int LaanerNummer   
        {
            get { return _laanerNummer; }  
        }


        public string Fornavn   // property
        {
            get { return _fornavn; }   // get method
           
        }

        public string Efternavn   // property
        {
            get { return _efternavn; }   // get method

        }

        public string FuldeNavn
        {
            get { return _fornavn + " " + _efternavn; }
        }

        public Laaner(int laanerNummer, string fornavn, string efternavn)
        {
            _laanerNummer = laanerNummer;
            _fornavn = fornavn;
            _efternavn = efternavn;
        }
            

    }
}
