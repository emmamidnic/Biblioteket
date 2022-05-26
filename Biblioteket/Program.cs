using System;

namespace Biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotek bibliotek = new Bibliotek("Sønderborg bibliotek");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = bibliotek.MainMenu();
            }
                 
           
        }
    }
}
