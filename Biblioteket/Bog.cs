using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Bog
    {
        private string titel;
        private string forfatter;
        private string isbn;
        DateTime udlaansdato;

        public string Titel   // property
        {
            get { return titel; }   // get method
            set { titel = value; }  // set method

        }

        public string Forfatter           
        {
            get { return forfatter; }   
            set { forfatter = value; }  

        }

        public string Isbn
        {
            get { return isbn; }   
            set { isbn = value; }  

        }
    }
}
