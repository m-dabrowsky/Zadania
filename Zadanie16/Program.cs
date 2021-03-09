using System;
/*
Program który rekurencyjnie oblicza kolejne wartości n! (silnia)
gdzie n>0 i wynik wyświetla na ekranie komputera
 */


namespace Zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program s = new Program();

            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            // Wyświetlenie wyniku
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"{i}! = {s.Silnia(i)}");
            }


        }

        public long Silnia(int liczba) 
        {
            long zwrot = 1;
            if (liczba >= 2)
                zwrot = liczba * Silnia(liczba - 1);
            return zwrot;
        }

    }
}
