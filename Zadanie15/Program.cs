using System;
/*
 Program który sortuje n liczb z wykorzystaniem klasy i metod
*/



namespace Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {

                                        
            int[] liczby = {51,302,1,25,84,12};                 // stworzenie tablicy liczb
            int n = liczby.Length;                              // określenie długości tablicy
          

            Program babelki = new Program();
            babelki.CzytajDane(liczby, n);
            babelki.PrzetworzDane(liczby, n);
            babelki.WyswietlWynik(liczby, n);
        }


        public void CzytajDane(int[] liczby, int n)
        {
            // Metoda wyświetla dane
            
            Console.Write("Liczby nieposortowane: ");
            for (int i = 0; i < n; i++)
            {
                if (i < n-1)
                    Console.Write(liczby[i] + ", ");
                else
                    Console.Write(liczby[i] + ".");
            }
            Console.WriteLine();
        }



        public void PrzetworzDane(int[] liczby, int n)
        {
            // Metoda sortuje wczytane dane według sortowania bombelkowe

            int x;

            // wykona sprawdzenie dla n-1 liczb
            for (int i = 0; i < n - 1; i++)
            {
                // dla każdej z liczb w tablicy sprawdza z pozostałymi liczbami n-1-i
                for (int j = 0; j < n-i-1; j++)
                {
                    
                    // w przypadku gdy kolejna liczba jest mniejsza od aktualnej
                    if (liczby[j] > liczby[j+1])
                    {
                        x = liczby[j];                  // dodaj aktualną liczbę do zmiennej tymczasowej (żeby nie zgubić liczby)
                        liczby[j] = liczby[j+1];        // wpisz kolejną liczbę w miejsce aktualnej (utraci się pierwotną liczbe)
                        liczby[j+1] = x;                // pierwotną liczbę przechowywaną w zmiennej x wpisz do miejsce kolejnej lizby
                    }
                }

            }

        }

        public void WyswietlWynik(int[] liczby, int n)
        {
            int i;
            Console.WriteLine();
            Console.Write("Liczby posorotwane to: ");

            for (i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write($"{liczby[i]}, ");
                else
                    Console.Write($"{liczby[i]}.");
            }
            Console.WriteLine();
        }


    }
}
