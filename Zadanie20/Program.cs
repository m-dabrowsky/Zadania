using System;

namespace Zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Program lenString = new Program();
            //lenString.Len();

            //2
            //Program sepChar = new Program();
            //sepChar.Sep();

            //3
            //Program revChar = new Program();
            //revChar.Rev();

            //4
            //Program countString = new Program();
            //countString.Count();

            //5
            //Program countAlphabet = new Program();
            //countAlphabet.CountAlphabet();

            //6
            //Program wordCounts = new Program();
            //wordCounts.WrdCounts();

            //7
            //Program SortString = new Program();
            //SortString.SortStr();

            //8
            Program ExtractString = new Program();
            ExtractString.ExtractStr();

        }

        public void Len() 
        {
            /*
             1. Program obliczający długość stringa bez użycia funkcji
             */

            int l = 0;

            Console.Write("Podaj string: ");
            string s = Console.ReadLine();

            foreach (char chr in s)  
            {
                l += 1;
            }

            int l1 = s.Length; 
            Console.WriteLine($"Długość podanego stringa wynosi: {l}");
            Console.WriteLine($"Długoścza pomocą funkcji: {l1}");

        }

        public void Sep()
        {
            /*
             2. Program oddzielajacy litery w stringu
             */
            int l = 0;

            Console.Write("Podaj string: ");
            string s = Console.ReadLine();

            Console.WriteLine("Litera mi w stringu są:");
            while (l <= s.Length - 1) 
            {
                Console.Write("{0} ", s[l]);
                l++;
            }
            Console.WriteLine();

            // LUB
            //foreach (char chr in s)
            //{
            //    Console.Write("{0} ", chr);
            //}

        }

        public void Rev()
        {
            /*
             3. Program odwracający kolejność oddzielonych liter
             */
            
            Console.Write("Podaj string: ");
            string s = Console.ReadLine();
            int l = s.Length;

            Console.WriteLine();

            while (l - 1 >= 0)
            {
                Console.Write("{0} ", s[l-1]);
                l--;
            }

        }


        public void Count()
        {
            /*
             4. Program zliczający wyrazy w stringu
             */

            Console.Write("Podaj string: ");
            string s = Console.ReadLine();
            int i = 0;
            int c = 1;

            Console.WriteLine();

            while (i <= s.Length-1)
            {
                if (s[i] == ' ')
                    c += 1;
                i++;
            }
            Console.Write("Liczba wyrazów w stirngu to {0}", c);

        }

        public void CountAlphabet()
        {
            /*
             5. Program zliczający wyrazy alfabetu, cyfr i znaków specjalnych w stringu
             */
            int alphabet = 0, digit = 0, special = 0;
            int i = 0;


            Console.Write("Podaj string: ");
            string s = Console.ReadLine();
            int l = s.Length;

            while (i < l) 
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z')) // sprawdza czy dana litera leży w pedziale a-z lub A-Z
                {
                    alphabet++;
                }
                else if (s[i] >= '0' && s[i] <= '9')                              // sprawdza czy dana litera jest cyfrą od 0-9
                {
                    digit++;
                }
                else                                                              // każde inne litery niż powyższe traktuje jak specjalne
                {
                    special++;
                }
                i++;
            }

            Console.WriteLine($"Liczba liter: {alphabet}");
            Console.WriteLine($"Liczba cyfr: {digit}");
            Console.WriteLine($"Liczba znaków specjalnych: {special}");
        }

        public void WrdCounts()
        {
            /*
             6. Program znajdujący najczęściej występującą litere ****
             */
            int max, l, i;
            int ascii;
            int[] ch_fre = new int[255]; // tablica przechowująca częstoliwośc wystąpień
            

            Console.Write("Podaj string: ");
            string str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 255; i++) // ustatwienie częstotliowści wszystkich liter na 0
            {
                ch_fre[i] = 0;
            }

            // Odczytanie częstoliwości liter
            i = 0;
            while (i < l-1)
            {
                ascii = (int)str[i];  // zamiana znaku na kod ASCI
                ch_fre[ascii] += 1;   // dodanie wystąpienia danego znaku do tablicy
                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)        // Jeśli nie jest spacją
                {
                    if (ch_fre[i] > ch_fre[max]) // porównuje każdy kod ASCII. Jeśli ma wiecej wystąpień niż 0
                        max = i;                 // przypisuje max dany kod. 
                }

            }
            Console.WriteLine($"Najczęsciej występującą literą jest {(char)max}, która występuje {ch_fre[max]}");


        }


        public void SortStr()
        {
            /*
             7. Program sortujący rosnąco tablice string ????????
             */

            char chr;

            Console.Write("Podaj string: ");
            string s = Console.ReadLine();
            int l = s.Length;

            char[] arr = s.ToCharArray(0, 1); //zaczyna od 0 pozycji i pobiera 1 znak

            for (int i = 0; i < l-1; i++)
            {
                for (int j = 0; j < l-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        chr = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = chr;
                    }

                }
            }
            Console.WriteLine("Po sortowaniu string wygląda tak:");
            foreach (char c in arr) 
            {
                chr = c;
                Console.WriteLine("{0}", chr);
            }
            Console.WriteLine();
        }

        public void ExtractStr()
        {
            /*
             8. Program wyciągający wyraz ze stringa bez użycia funkcji ***
             */
            int c=0;

            Console.Write("Podaj string: ");
            string str = Console.ReadLine();
            int ln = str.Length;

            char[] arr = str.ToCharArray(0, ln);


            Console.Write("Podaj od której pozycji wyciąć teskt: ");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj dlugość wycinanego ciągu: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wycięta część ze stringa to: ");
            while(c < l)
            {
                Console.Write(arr[position+c-1]);
                c++;
            }
            Console.WriteLine();


        }

    }
}
