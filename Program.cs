using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201019
{
    class Program
    {
        static Random rnd = new Random();
        static int[] tomb = new int[100];
        static string anagramma = "INFORMATIKA";
        static void Main()
        {
            //Írjunk eljárást, mely egy 100 elemű tömböt feltölt kétjegyű véletlen - számokkal és egy másikat, amely egy 100 elemű tömb elemeit a képernyőre írja.
            TombFeltolt(); TombKiir();

            Console.ReadKey();
            Console.Clear();

            //200 csillag random színnel

            for (int i = 0; i < 200; i++)
            {
                RandomSzin();
                RandomHelyreIr();
            }

            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();

            //jelszógenerátor ASCII kódból

            Console.Write("Az új jelszava: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(RandomChar());
            }

            Console.ReadKey();
            Console.Clear();

            //anagramma és a tomb tömb intervalluma

            Console.WriteLine($"INFORMATIKA - {TombKever()}");
            Console.WriteLine(Intervallum());

            Console.ReadKey();
            Console.Clear();

            //osztályzatok értékelése

            for (int i = 1; i <= 5; i++)
            {
                Osztalyoz(i);
            }

            Console.ReadKey();
            Console.Clear();

            //hónapok számmá "konvertálása"
            HonapSzama("január");
            HonapSzama("március");
            HonapSzama("július");
            HonapSzama("december");

            Console.ReadKey();
            Console.Clear();

            //két oldala alapján téglalap kerülete-területe
            KerTer(5, 10);
            KerTer(3, 20);
            KerTer(10);

            Console.ReadKey();
            Console.Clear();

            //háromszög-egyenlőtlenség
            HaromszogE(10, 15, 20);
            HaromszogE(10, 15, 25);

            //folytköv


            Console.ReadKey();
        }

        static void TombFeltolt() //100 elemű tömböt (tomb) kétjegyű számokkal
        {
            for (int i = 0; i < 100; i++)
            {
                tomb[i] = rnd.Next(10, 100);
            }
        }

        static void TombKiir() //100 elemű tömböt (tomb)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{tomb[i]} ");
            }
        }

        static void RandomHelyreIr()
        {
            Console.SetCursorPosition(rnd.Next(0, Console.WindowWidth), rnd.Next(0, Console.WindowHeight));
            Console.Write("*");
        }

        static void RandomSzin()
        {
            //blue 9 - yellow 14
            Console.ForegroundColor = (ConsoleColor)rnd.Next(9, 15);
        }

        static char RandomChar()
        {
            return (char)rnd.Next(65, 91);
        }

        static string TombKever()
        {
            List<int> volt = new List<int>();
            string tmp = "";
            for (int i = 0; i < anagramma.Length; i++)
            {
                int elem;
                do
                {
                    elem = rnd.Next(0, anagramma.Length);
                } while (volt.Contains(elem));
                tmp += anagramma[elem];
                volt.Add(elem);
            }
            return tmp;
        }

        static string Intervallum()
        {
            int mini = 0, maxi = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[mini] > tomb[i]) mini = i;
                if (tomb[maxi] < tomb[i]) maxi = i;

            }
            return $"[{tomb[mini]}, {tomb[maxi]}]";
        }

        static void Osztalyoz(int jegy = 1)
        {
            switch (jegy)
            {
                case 1: 
                    Console.WriteLine("Elégtelen"); 
                    break;
                case 2:
                    Console.WriteLine("Elégséges");
                    break;
                case 3:
                    Console.WriteLine("Közepes");
                    break;
                case 4:
                    Console.WriteLine("Jó");
                    break;
                case 5:
                    Console.WriteLine("Jeles");
                    break;
            }
        }

        static void HonapSzama(string honap = "január")
        {
            switch (honap)
            {
                case "január":
                    Console.WriteLine(1);
                    break;
                case "február":
                    Console.WriteLine(2);
                    break;
                case "március":
                    Console.WriteLine(3);
                    break;
                case "április":
                    Console.WriteLine(4);
                    break;
                case "május":
                    Console.WriteLine(5);
                    break;
                case "június":
                    Console.WriteLine(6);
                    break;
                case "július":
                    Console.WriteLine(7);
                    break;
                case "augusztus":
                    Console.WriteLine(8);
                    break;
                case "szeptember":
                    Console.WriteLine(9);
                    break;
                case "október":
                    Console.WriteLine(10);
                    break;
                case "november":
                    Console.WriteLine(11);
                    break;
                case "december":
                    Console.WriteLine(12);
                    break;
            }
        }

        static void KerTer(int a = 1, int b = 1)
        {
            Console.WriteLine($"Téglalap kerülete: {2*(a+b)} egység");
            Console.WriteLine($"Téglalap területe: {a*b} egység");
        }

        static void HaromszogE(int a = 1, int b = 1, int c = 1)
        {
            if (a + b > c && a + c > b && b + c > a) Console.WriteLine($"Lehetséges a(z) {{{a}, {b}, {c}}} háromszög");
            else Console.WriteLine($"Nem lehetséges a(z) {{{a}, {b}, {c}}} háromszög");
        }
    }
}
