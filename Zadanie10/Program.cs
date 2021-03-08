using System;
/*
 Program który w 10-elementowej tablicy jednowymiarowej o nazwie DANE, umieszcza liczby 
od 0 do 9.
 */



namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;                     // rozmiar tablicy
            int i,j;

            int[] dane1 = new int[n];        // deklaracja tabliy typu int o rozmiarze n
            int[] dane2 = new int[n];
            Console.WriteLine($"Program wyświetla zawartość tablicy jednowymiarowej {n} elementowej");

            for (i = 0; i < n; i++)
            {
                dane1[i] = i;                // wpisywanie do tablicy kolejnych liczb od 0 do 9
                Console.WriteLine($"dane[{i}] = {i}");
            }

            Console.WriteLine();

            for (j = 0; j < n; j++)
            {
                dane2[j] = n-1-j;            // wpisywanie do tablicy liczb od 9 do 0    
                Console.WriteLine($"dane[{j}] = {n - 1 - j}");
            }

        }
    }
}
