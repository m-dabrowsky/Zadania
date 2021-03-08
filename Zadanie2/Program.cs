using System;

/*
 Napisz program który wyświetli na ekranie komputera wartość predefiniowanej stałej Pi = 3.14
Należy przyją format wyświetlania tej stałej z dokładnościa do pięciu miejsc po przecinku
 */


namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI= {0:#.#####}", Math.PI);
        }  
    }
}
