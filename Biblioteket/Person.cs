using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Person 
    {
        private string navn;
        private string email;

        public string Navn   // property
        {
            get { return navn; }   // get method
            set { navn = value; }  // set method

        }

        public string Email   // property
        {
            get { return email; }   // get method
            set { email = value; }  // set method

        }

    }
}
