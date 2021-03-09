using System;

/*
 Program który oblicza pole prostokąta z wykorzystaniem klas i metod
 */

namespace Zadanie14
{
    class Program
    {
        int a, b, wynik;
     
        
        public void CzytajDane ()
        {
            // Metoda umożliwia wprowadzenie boków a i b

            Console.Write("Podaj wartość a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj wartość b: ");
            b = int.Parse(Console.ReadLine());

        }

        
        public void PrzetworzDane()
        {
            //Metoda oblicza pole prstokata według wzoru A*B

            wynik = a * b; 

        }

        public void WyswietlWynik()
        {
            //Metoda oblicza pole prstokata według wzoru A*B

            Console.WriteLine($"Pole prostokąta o bokach {a} i {b}, wynosi {wynik}");

        }

        static void Main(string[] args)
        {
            Program pole_pr = new Program();
            pole_pr.CzytajDane();
            pole_pr.PrzetworzDane();
            pole_pr.WyswietlWynik();

        }

    }
}
