using System;
/*
 Program który za pomocą instrukcji for znajduje największą i najmniejszą liczbę ze zbioru n
wylosowanyh liczb całkowitych od 0 - 99 oraz oblicza średnią ze wszystkich liczb
 */
namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloscLiczb = 2, i;
            int liczba;
            int min, max;
            int suma = 0;

            Console.WriteLine($"Program losuje {iloscLiczb} liczb całkowitych od 0-99");
            Console.WriteLine("a następnie znajduje liczbe max i min oraz liczy średnią wszystkich liczb");

            Random r = new Random();
            min = r.Next(0, 100);
            
            max = min;
            suma = suma + max;
            Console.Write($"Wylosowano liczby: ");

            for (i = 1; i <= iloscLiczb; i++)               
            {
                liczba = r.Next(0, 100);                    
                
                if (i < iloscLiczb)                         
                {
                    Console.Write($"{liczba}, ");
                   
                }
                else 
                {
                    Console.Write($"{liczba}.");
                }

                if (max < liczba) max = liczba;
                if (liczba < min) min = liczba;

                suma = suma + liczba;     
            }
            Console.WriteLine();
            Console.WriteLine($"Największa liczba to {max}");
            Console.WriteLine($"Najmniejsza liczba to {min}");
            Console.WriteLine($"Średnia wynosi {suma/iloscLiczb}");
        }
    }
}
