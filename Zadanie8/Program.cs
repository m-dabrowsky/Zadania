using System;

/*
 Napisz program wyświetlajacy tabliczkę mnożenia dla liczb 1-100 (tj. 10 x 10)
 z wykorzystaniem podwójnej pętli for
 */

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {

            int row, column;
            int n = 10;

            Console.WriteLine("Tabliczka mnożenia 10x10");
            Console.WriteLine();

            for (row = 1; row <= n; row++) 
            {
                
                for (column = 1; column <= n; column++)
                {
                    Console.Write(row*column + "\t");
                }
                Console.WriteLine();

            }


        }
    }
}
