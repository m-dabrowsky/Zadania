using System;
/*
 Program który w tablicy jednowymiarowej 100-elementowej o nazwei DANE
umieszcza liczby 1-100, a następnie je sumuje. 
 */


namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;                // liczba elementów tablicy
            int suma = 0;

            Console.WriteLine("Program sumuje liczby liczby od 1 do 100 znajdujące się w tablicy jednowymiarowej");
            Console.WriteLine();

            int[] tab = new int[n];

            // wstawienie elementów do tablicy
            for (int i = 0; i < n; i++)
            {
                tab[i] = i+1;
                //Console.Write(tab[i]);
            }
            

            // obliczanie sumy 
            foreach (int item in tab)  // dla każdego elementu w tablicy DANE
            {
                suma += item;           // do sumy dodaje po kolei każdy element
            }

            Console.WriteLine($"Suma liczb od 1 do 100 wynosi {suma}");

        }
    }
}
