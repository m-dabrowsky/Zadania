using System;

namespace Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 
            //Program charsEx = new Program();
            //charsEx.ChrEx("abc");

            //2.
            //Program Triangle = new Program();
            //Triangle.TriAngle();

            // 3.
            //Program even = new Program();
            //even.EvenNumber();

            //4. 
            Program binary = new Program();
            binary.BinaryNumber();

        }

        public void ChrEx(string letters)
        {
            /*
             1. Program odwracający podany ciąg znaków
             */

            char[] chars = letters.ToCharArray();               // Tworzy tablice z wyodkrębnionymi znakami ze Stringa
            Array.Reverse(chars);                               // Odwraca elementy tabliy
            Console.WriteLine(string.Join(null, chars));        // łączy tablice w string - niczym nie oddzielajac elementów

        }


        public void TriAngle()
        {
            /*
             2. Program pobierający liczbę z której zostanie zbudowany trójkąt oraz szerokość trójkąta
            */
            Console.Write("Podaj liczbę: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Podaj szerokość trójkąta: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < width;)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                width--;
            }
        }


        public void EvenNumber()
        {
            /*
             Program sprawdzający czy podane dwie liczby są parzyste
             */
            bool bothEven;
            while (true)
            {
                Console.Write("Podaj 1 liczbę: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Podaj 2 liczbę: ");
                int number2 = int.Parse(Console.ReadLine());


                bothEven = ((number1 % 2 == 0) && (number2 % 2 == 0)) ? true : false;

                Console.WriteLine(bothEven ? "Podane liczby (obie) są parzyste" : "Przynajmniej jedna liczba jest nieparzysta");

            }
        }

        public void BinaryNumber()
        {
            /*
             Program konwertujacy podaną wartość na wartość Binarną
             */
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            int bin = int.Parse(Convert.ToString(number, 2));

            Console.WriteLine($"Liczba Binarna to: {bin}");

        }


    }
}
