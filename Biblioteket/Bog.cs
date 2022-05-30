using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Bog
    {
        private string _titel; //field
        private string _forfatter;
        private string _isbn;
        DateTime udlaansdato;

        public Bog(string titel, string forfatter, string isbn) // Constructor som skal bruges til LaanBog(Bog bogen) metoden
        {
            _titel = titel;
            _forfatter = forfatter;
            _isbn = isbn;
        }


        public string Titel   // property
        {
            get { return _titel; }   // get method
            set { _titel = value; }  // set method

        }

        public string Forfatter           
        {
            get { return _forfatter; }   
            set { _forfatter = value; }  

        }

        public string Isbn
        {
            get { return _isbn; }   
            set { _isbn = value; }  

        }
    }
}
