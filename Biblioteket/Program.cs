using System;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek nytObj = new Bibliotek("Sønderborg bibliotek");

            Console.WriteLine(nytObj.HentBibliotek());

            Console.ReadLine();
        }
    }
}
