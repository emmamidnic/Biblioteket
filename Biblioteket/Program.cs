using System;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg bibliotek");
            
            // så længe showMenu er true, kører programmet. I MainMenu(); bliver showMenu til false, hvis user vælger at aflsutte programmet.
            bool showMenu = true; 
            while (showMenu)
            {
                showMenu = bibliotek.MainMenu();
            }

        }
    }
}
