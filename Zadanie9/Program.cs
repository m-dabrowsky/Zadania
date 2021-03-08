using System;

/*
 Napisz program który wyświetla duze litery alfabetu od A do Z i od Z do A
z wykorzytsaniem pętli for
 */


namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak;

            Console.WriteLine("Wyświetlenie duzy liter alfabetu");
            Console.WriteLine();

            // od A do Z
            for (znak = 'A'; znak<='Z'; znak++)
            {
                if (znak < 'Z')
                {
                    Console.Write($"{znak}, ");
                }
                else 
                {
                    Console.Write($"{znak}.");
                }
            }
            Console.WriteLine();

            // od Z do A
            for (znak = 'Z'; znak >= 'A'; znak--)
            {
                if (znak > 'A')
                {
                    Console.Write($"{znak}, ");
                }
                else
                {
                    Console.Write($"{znak}.");
                }
            }
            Console.WriteLine();


        }
    }
}
