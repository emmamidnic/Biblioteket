﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner : Person // nedarver fra Person klassen
    {
        private int _laanerNummer;
       
        public int LaanerNummer   
        {
            get { return _laanerNummer; }  
        }

        public Laaner(int laanerNummer, string navn, string email)
        {
            _laanerNummer = laanerNummer;
            Navn = navn;
            Email = email;
        }


        public override string ToString() // laver objektet til string
        {
            return string.Format("Denne bruger er: {0}", Navn);
        }
    }
}
