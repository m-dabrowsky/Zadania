using System;
using System.Collections;

/*
 Korzystając z kolekcji ArrayList(), program który do kolekcji tego typu dodaje 6 liczb, a następnie je sortuje.
Po wykonaniu tej operacji należy dokonać usunięcia drugiego elementu z listy, dodać nowy element do listy i dokonać ponownego sortowania. 
 */


namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            // dodawanie kolejnych elementów do listy
            lista.Add(20);
            lista.Add(51);
            lista.Add(-72);
            lista.Add(4);
            lista.Add(14);
            lista.Add(-4);

            // wyświetlenie listy nieposortowanej
            Console.Write("Elementy nieposortowane: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (i< lista.Count-1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.Write(lista[i] + ".");
            }
            Console.WriteLine();

            lista.Sort();                               // sortowanie listy


            // wyświetlenie listy posortowanej
            Console.Write("Elementy posortowane: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.Write(lista[i] + ".");
            }

            // usunięcie drugiego elementu z listy

            Console.WriteLine();
            lista.RemoveAt(1);                            // usunięcie drugiego elementu
            lista.Add(10);                                // dodanie nowego elementu
            Console.WriteLine("Usunięto drugi element z listy i dodano nowy");

            // ponowne sortowanie i wyświetlenie wyniku
            lista.Sort();
            Console.Write("Elementy posortowane po dodaniu elementu: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (i < lista.Count - 1)
                    Console.Write(lista[i] + ", ");
                else
                    Console.Write(lista[i] + ".");
            }

            Console.WriteLine();
        }
    }
}
