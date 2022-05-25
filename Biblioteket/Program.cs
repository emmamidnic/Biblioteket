using System;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek nytObj = new Bibliotek("Sønderborg bibliotek");

            nytObj.OpretLaaner(1, "Emma", "Niclasen");
            Console.WriteLine(nytObj.HentBibliotek());
            Console.WriteLine(nytObj.HentLaaner());

            Console.ReadLine();
        }
    }
}
