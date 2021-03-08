using System;

/*
Program który w zadeklarowanej tablicy dwuwymiarowej 10 x 10
o nazwie macierz, umieszcza na przekątnej liczbę 1, a poza przekątną 0.
Dodatkowo program powinien obliczać sumę wyróżnionych w tablicy elementów
tj. elementów znajdujących się na jej przekątnej.

LUB umieszczanie na przekątnej liczb 0-9
 */

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, i, j, suma;

            int[,] macierz = new int[n, n];

            Console.WriteLine($"Program wyświetla zawartość tablicy dwuwymiarowej {n} x {n} elementowej");
            Console.WriteLine();

            // wpisywanie do tabliy 1 na przekątnej i 0 poza przekątną

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        macierz[i, j] = 1;      // żeby umieścić na przekatnej liczby od 0-9 - w miejsce 1 wstawić i
                    }
                    else
                        macierz[i, j] = 0;
                }
            }


            // wyświetlanie zawartości tablicy
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                   Console.Write($"{macierz[i, j]} ");
                }
                Console.WriteLine();
            }

            // obliczenie sumy elementów na przekątnej
            suma = 0;

            for (i = 0; i < n; i++)
            {
                suma = suma + macierz[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"Suma wyróżnionych elementów wynosi {suma}");

        }
    }
}
