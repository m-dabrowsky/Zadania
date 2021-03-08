using System;
/*
 Program który za pomocą instrukcji while wyświetla liczby całkowite od 1-20 
 Program który za pomocą for sumuje liczby całkowite od 1-100
 */



namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int suma = 0;

            while (i <= 20) 
            {
                if (i < 20)
                {
                    Console.Write(i + ", ");
                }
                else 
                {
                    Console.WriteLine(i + ".");
                }
                i++;
            }


            for (i = 1; i <= 100; i++) 
            {
                suma = suma + i;
            }
            Console.WriteLine($"Suma liczb od 1 do 100 wynosi {suma}.");


        }
    }
}
