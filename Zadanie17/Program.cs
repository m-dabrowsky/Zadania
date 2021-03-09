using System;
/*
 Napisz program który rekurencyjnie znajduje 10 pierwszych liczb Fibonacciego i 
wyświetla je za ekranie komputera.
 */
namespace Zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Program liczby = new Program();

            Console.WriteLine($"Program znajduje rekurencyjnie {n} liczb Fibonacciego");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(liczby.Fib(i) + " ");
            }

        }

        public int Fib(int n) 
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                default: return Fib(n - 1) + Fib(n - 2);

            }
        }
    }
}
