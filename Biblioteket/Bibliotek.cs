using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Bibliotek
    {
        private string _biblioteksNavn;
        private List<Laaner> laanere = new List<Laaner>();
             

        public Bibliotek(string biblioteksNavn)
        {
            _biblioteksNavn = biblioteksNavn;
        }

        

        public bool MainMenu()
        {
            
            Console.Clear();
            Console.WriteLine("Du kan vælge imellem følgende:");
            Console.WriteLine("1) Vis bibliotekets navn og dato");
            Console.WriteLine("2) Opret låner");
            Console.WriteLine("3) Udskriv alle lånere");
            Console.WriteLine("4) Find og udskriv en låner via lånernummer");
            Console.WriteLine("5) Afslut");
            Console.Write("\n\nIndtast dit valg (1,2,3 eller 4):  ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(HentBibliotekTEST());
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine(OpretLaanerTEST());
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Her er listen over alle registrerede lånere: \n");
                    Console.WriteLine(HentAlleLaanereTEST());
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Indtast lånernummer: ");
                    int laanerNummer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(FindLaaner(laanerNummer)); 
                    Console.ReadLine();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

        private static string HentBibliotekTEST()
        {
            string navnBibliotek = "Sønderborg Bibliotek";
            return string.Format("Velkommen til {0} - Datoen i dag er: {1}", navnBibliotek, DateTime.Now);
        }
             


        public string OpretLaanerTEST()
        {
            Console.Write("Indtast dit navn: ");
            string navn =  Console.ReadLine();

            Console.Write("Indtast din email: ");
            string email = Console.ReadLine();

            Random rnd = new Random();
            int laanerNummer = rnd.Next();
                        
            laanere.Add(new Laaner(laanerNummer, navn, email));
            return string.Format("\n\nBruger oprettet:\nNavn: {0}\nLånernummer: {1}\nEmail: {2}\n\n", navn, laanerNummer, email); 
                           
        }

        public string HentAlleLaanereTEST() 
        {
            string result = "";

            foreach (Laaner l in laanere)
            {
                result += string.Format("Navn: {0} - Lånernummer: {1} - Email: {2}\n", l.Navn, l.LaanerNummer, l.Email);
            }

            return result;
        }

        public string FindLaaner(int laanerNummer)
        {

            foreach  (Laaner l in laanere)
            {
                if (laanerNummer == l.LaanerNummer)
                {
                    return l.ToString();
                }
            }
            return "";
        }


    }
}
