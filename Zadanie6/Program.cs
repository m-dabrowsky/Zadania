using System;

/*
 Program który za pomocą for sumuje liczby parzyste od 1-100
 Program który za pomocą do--while sumuej liczby parzyste od 1-100
 */


namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int suma = 0;

            // dla for
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                 
                }
            }
            Console.WriteLine(suma);


            // dla do.. while
            do
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                    i++;
                }
            }
            while (i <= 100);
            Console.WriteLine(suma);
        }
    }
}
