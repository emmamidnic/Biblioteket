using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Person 
    {
        private string navn; // field
        private string email;
        List<Bog> Bog  = new List<Bog>(); // Liste som skal bruges til LaanBog(Bog bogen) metoden

        public string Navn   // property
        {
            get { return navn; }   // get method
            set { navn = value; }  // set method

        }

        public string Email   
        {
            get { return email; }   
            set { email = value; }  

        }

    }
}
