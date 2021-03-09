using System;
/*
 Program który zawiera proces dziedziczenia - klasa wyprowadzona KADRA
dziedziczy właściwości po klasie bazowej OSOBA oraz zawiera dwa dodatkowe pola:
WYKSZTAŁCENIE i STANOWISKO oraz dwie dodatkowe metody wczytaj() oraz wyświetl()
 */
namespace Zadanie18
{
    class Osoba
    {
        String nazwisko;
        String imie;
        String ulice;
        String kod;
        String miasto;


        public void Wczytaj()
        {
            Console.Write("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();

            Console.Write("Podaj imie: ");
            imie = Console.ReadLine();

            Console.Write("Podaj ulice: ");
            ulice = Console.ReadLine();

            Console.Write("Podaj kod: ");
            kod = Console.ReadLine();

            Console.Write("Podaj miasto: ");
            miasto = Console.ReadLine();

        }

        public void Wyswietl()
        {
            Console.WriteLine($"{nazwisko} {imie}, ul.{ulice}, {kod}, {miasto}");
        }


    }

    class Kadra : Osoba
    {
        String wyksztalcenie;
        String stanowisko;

        public void Wczytaj1()
        {
            Wczytaj();                          // wywołanie metody wczytaj z klasy OSOBA

            Console.Write("Podaj wyksztalcenie: ");
            wyksztalcenie = Console.ReadLine();

            Console.Write("Podaj stanowisko: ");
            stanowisko = Console.ReadLine();


        }


        public void Wyswietl1()
        {
            Wyswietl();
            Console.WriteLine($"{wyksztalcenie}, {stanowisko}");
        }

    }

    class Program 
    {
        static void Main(string[] args)
        {
           
            Kadra pracownik = new Kadra();
          
            pracownik.Wczytaj1();
            pracownik.Wyswietl1();

        }

    }
}
