using System;
/*
 Napisz program w którym użytkownik zgaduje całkowitą liczbę losową z przedziału
od 0 do 9 generowaną przez komputer
 */


namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int losujLiczbe, zgadnijLiczbe;
      
            Random r = new Random();
            losujLiczbe =  r.Next(0,10);
            Console.WriteLine(losujLiczbe);

            

            while (true)
            {
                Console.Write("Myśle o pewnej liczbe z zakres od 0-9, zgadniesz ją?: ");
                zgadnijLiczbe = int.Parse(Console.ReadLine());

                if (losujLiczbe == zgadnijLiczbe)
                {
                    Console.WriteLine("Brawo! Zgadłeś.");
                    break;
                }
                else
                {
                    Console.WriteLine("Spróbuj jeszcze raz.");
                    
                }

            }
            

        }
    }
}
