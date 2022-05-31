using System;
using System.Collections.Generic;
using System.IO;

namespace Biblioteket
{
    public class Bibliotek
    {
        private string _biblioteksNavn;
        private List<Laaner> laanere = new List<Laaner>(); // liste, hvor alle oprettede lånere bliver lagt til
        private static string path;


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
            Console.Write("\n\nIndtast dit valg (1,2,3,4 eller 5):  ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(HentBibliotek());
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine(OpretLaaner());
                    Console.ReadLine();
                    return true;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Her er listen over alle registrerede lånere: \n");
                    Console.WriteLine(HentAlleLaanere());
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.Clear();
                    Console.Write("Indtast lånernummer: ");
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

        private static string HentBibliotek()
        {
            string navnBibliotek = "Sønderborg Bibliotek";
            return string.Format("Velkommen til {0} - Datoen i dag er: {1}", navnBibliotek, DateTime.Now);
        }


        public string OpretLaaner()
        {
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();

            Console.Write("Indtast din email: ");
            string email = Console.ReadLine();

            Random rnd = new Random(); //Klasse som giver random nr. til oprettede lånere 
            int laanerNummer = rnd.Next();

            laanere.Add(new Laaner(laanerNummer, navn, email));
            LaanerTXT();
            return string.Format("\n\nBruger oprettet:\nNavn: {0}\nLånernummer: {1}\nEmail: {2}\n\n", navn, laanerNummer, email);

        }

        public string HentAlleLaanere()
        {
            string result = "";

            foreach (Laaner l in laanere)
            {
                result += string.Format("Navn: {0} - Lånernummer: {1} - Email: {2}\n", l.Navn, l.LaanerNummer, l.Email);
            }

            return result;
        }

        // metode, som checker om det indtastede laanerNummer matcher med et låner nummer hos et lånerobjekt i listen
        public string FindLaaner(int laanerNummer)
        {
            foreach (Laaner l in laanere)
            {
                if (laanerNummer == l.LaanerNummer)
                {
                    return l.ToString();
                }
            }

            return string.Format("\n\nDer findes ingen bruger med det lånernummer!");
        }


        public void LaanerTXT()
        {
            foreach (Laaner l in laanere)
            {
                DateTime localDate = DateTime.Now;

                path = $"C:\\Users\\fo2931\\Desktop\\BIBLIOTEKET\\{l.LaanerNummer}.txt";

                string txt = $"Denne bruger blev oprettet: {localDate}\n";
                string datoOgTid = $"Dato: {localDate}\n";


                string laanertxt = $"\n{l.ToString()} - Email: {l.Email} - Lånernummer: {l.LaanerNummer}";

                File.WriteAllText(path, txt);
                File.AppendAllText(path, laanertxt);

            }

        }

        // TODO: En metode, som kan gemme alle lånte bøger i en liste på personen

    }
}
