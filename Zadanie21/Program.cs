using System;

namespace Zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Program countSpaces = new Program();
            //countSpaces.CountSpace();

            //2.
            //Program sumArray = new Program();
            //sumArray.SumArr();

            //3.
            //Program swapNumbers = new Program();
            //swapNumbers.SwapNum();

            //4
            //Program numbersFibonacci = new Program();
            //numbersFibonacci.nFib();

            //5
            //Console.Write("Podaj Liczbę pierwszą: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if(PrimeNum(num))
            //    Console.WriteLine($"{num} jest liczba pierwsza");
            //else
            //    Console.WriteLine($"{num} nie jest liczba pierwsza");

            //6 
            //FactNum();

            //7
            Console.Write("Podaj liczbe: ");
            int num = Convert.ToInt32(Console.ReadLine());
            FibonacciNum(num);

        }


        public void CountSpace()
        {

            /*
             1. Program który liczby liczbę spacji w stringu
             */

            Console.WriteLine("Podaj dowolny string: ");
            string str = Console.ReadLine();
            int len = str.Length;
            int cnt = 0;

            for (int i = 0; i <= len - 1; i++)
            {
                if (str[i] == ' ')
                {
                    cnt++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Liczba spacji w stringu to: {cnt}");

        }

        public void SumArr()
        {

            /*
             2. Suma elementów w tablicy
             */

            int[] arr = { 1, 2, 3, 4, 5 };

            int len = arr.Length;
            int sum = 0;

            for (int i = 0; i <= len-1 ; i++)
            {
                sum += arr[i];
                Console.WriteLine($"Element - {i} : {arr[i]}");
            }
            
            Console.WriteLine($"Suma elementów w tablicy wynosi {sum}");
        }

        public void SwapNum()
        {

            /*
             3. Zamiana między sobą dwóch wartości int 
             */

            int tmp;

            Console.WriteLine("Podaj liczbe 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj liczbe 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            tmp = num1;
            num1 = num2;
            num2 = tmp;

            Console.WriteLine($"Teraz num1 wynosi: {num1}, a num2 wynosi {num2}");

        }


        public void nFib()
        {

            /*
             4. Program wyświetlający n liczb Fibonacii
             */
            int num1 = 0;
            int num2 = 1;
            int tmp;

            Console.WriteLine("Podaj ile wyświetli liczb Fibonacciego: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                tmp = num1;
                num1 = num2;
                num2 = tmp + num2;
                Console.WriteLine(num1);
            }

            
        }

        public static bool PrimeNum(int n)
        {

            /*
             5. Program sprawdzający czy liczba jest liczba pierwszą
             */
           
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false; 
            }
            return true;

        }

        public static void FactNum()
        {

            /*
             6. Program znajdujacy iloczyn podanej liczby
             */
            int wynik = 1;

            Console.WriteLine("Podaj liczbe: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                wynik *= i;
            }
            Console.WriteLine();
            Console.WriteLine($"Wynikiem jest: {wynik}");

            
        }

        public static int FibonacciNum(int n)
        {

            /*
             7. Program wyświetlający liczbe Fibonacci odpowiadającą podanej liczbie
             */

            if (n <= 2)
                return 1;
            else
                return FibonacciNum(n - 1) + FibonacciNum(n - 2);


        }



    }












}
