using System;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg bibliotek");

           
            Console.WriteLine(bibliotek.HentBibliotek());

            Console.WriteLine(bibliotek.OpretLaaner(1, "Emma", "Niclasen"));
            Console.WriteLine(bibliotek.OpretLaaner(2, "Andrias", "Joensen"));
            Console.WriteLine(bibliotek.OpretLaaner(3, "Knút", "Joensen"));

            Console.WriteLine("Her er en oversigt over registrerede lånere: ");
            Console.WriteLine(bibliotek.HentAlleLaanere());

            Console.ReadLine();
        }
    }
}
