using System;

/*
 Program który oblicza sume, róznice, iloczyn, iloraz lda dwoch liczb x i y.
W pogramie przyjmujemy zmienne xi y które są double. 
Wynik zapisać z dokładnością do dwóch miejsc po przecinku
 */

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma, roznica, iloczyn, iloraz;

            
            Console.Write("Podaj wartość 1 liczby: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Podaj wartość 2 liczby: ");
            double y = double.Parse(Console.ReadLine());

            suma = x + y;
            roznica = x - y;
            iloczyn = x * y;
            iloraz = x / y;


            Console.WriteLine("Wynik dodawania {0:#.##}", suma);
            Console.WriteLine("Wynik roznicy {0:#.##}", roznica);
            Console.WriteLine("Wynik iloczynu {0:#.##}", iloczyn);
            Console.WriteLine("Wynik ilorazu {0:#.##}", iloraz);

        }

        




    }
}
