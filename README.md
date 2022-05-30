Biblioteket
============

Lavet af: Emma Midjord Niclasen

Description
------------
Dette projekt er et bibliotekssystem, hvor det er muligt at oprette og udskrive lånere. Ved 
start af programmet bliver user bedt om at vælge i mellem en af følgende muligheder:

* Vis bibliotekets navn og dato
* Opret låner
* Udskriv alle lånere
* Find og udskriv en låner via lånernummer
* Afslut

Programmet kører indtil user vælger at afslutte programmet.


Upcoming Features (TODO)
--------

Der skal laves en metode, som gemmer de bøger en person låner i en liste på personen. Bog klassen med fields og
properties, og listen, som skal indeholde bøgerne er lavet. Det sidste som mangler at blive udviklet, er selve LaanBog(Bog bogen) metoden.


Changelog
--------

**Version 6**

I Bibliotek class blev oprettet:
* Metode: FindLaaner(int laanerNummer), som gør det muligt at finde en specifik låner 
* Metode: LaanerTXT(), som gemmer alle lånere i en fil når de bliver oprettet

**Version 5 (+4):**

Person class blev oprettet med:
* Fields: navn og email
* Properties til begge felter


I Laaner class blev navn og dets property fjernet, da Laaner class blev sat til at nedarve fra Person class

I bibliotek class blev MainMenu og metoderne tilpasset, således at email også bliver brugt ved oprettelse og udskrift af lånere.

 
(Version 4)
I Bibliotek class blev en bool MainMenu() oprettet og alle metoder i klassen blev tilpasset, således at 
de kunne bruges i denne bool.


**Version 3:**

I bibliotek class blev oprettet:
* List< Laaner > laanere = new List< Laaner >();
* Metode: HentAlleLaanere(), der samler alle lånere i en lang string
* Metode: OpretLaaner() blev tilpasset, så alle oprettede lånere blev tilføjet til laanere listen, 
og en retur streng tilføjet med info om lånere.

**Version 2 (+1):**

(Version1)
Bibliotek class blev oprettet med:
* Field: bibliotekNavn
* Constructor
* Metode: HentBibliotek() - returnerer en string "Velkommen til < biblioteksNavn > - datoen idag er: < aktuel dato >".

Desuden blev der lavet:
* objekt af Bibliotek-klassen, hvor navn = "Sønderborg bibliotek"
* HentBibliotek("Sønderborg Bibliotek"); i Main metoden.

(Version2)
Laaner class blev oprettet med:
* Fields: int laanerNummer og string navn
* ReadOnly-properties til begge felter
* Constructor, som tager imod laanerNummer og navn, og initialiserer felterne. 

I bibliotek-klassen blev lavet:
* Metode: OpretLaaner(), som tager imod laanerNummer og navn. 
* Metode: HentLaaner(), som returnerer en streng med laanerNummer, navn og biblioteksNavn.

I main metoden blev et låner-objekt oprettet, og metoderne testet.

En xUnit test blev lavet til sidst for at kontrollere, om strengen indeholder det korrekte navn på låneren.




Known Issues
--------
* Der bliver ikke checket, om brugeren indtaster en gyldig email addresse



Bugreporting
--------
