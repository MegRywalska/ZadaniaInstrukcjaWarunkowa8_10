using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania8_10
{
    internal class Zadania
    {
        /*Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy da
        się z tych odcinków zbudować trójkąt, czy też nie.
        Wskazówka: Z trzech odcinków można zbudować trójkąt, jeżeli suma długości każdych dwóch
        odcinków jest większa od długości trzeciego odcinka*/
        public static void Zadanie8()
        {
            Console.Write("Podaj dlugosc odcianka pierwszego: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj dlugosc odcianka drugiego: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj dlugosc odcianka trzeciego: ");
            int c = Convert.ToInt32(Console.ReadLine());

            a *= a;
            b *= b;
            c *= c;

            if (a + b == c)
            {
                Console.WriteLine("Można stworzyć trójkąt prostokątny. ");
            }
            else if (b + c == a)
            {
                Console.WriteLine("Można stworzyć trójkąt prostokątny. ");
            }
            else if (c + a == b)
            {
                Console.WriteLine("Można stworzyć trójkąt prostokątny. ");
            }
            else
            {
                Console.WriteLine("Nie można stworzyć trójkąt prostokątny. ");
            }
        }

        /*Dana jest funkcja kwadratowa f(x)=ax^2+bx+c. Napisać program wczytujący współczynniki
        funkcji kwadratowej (a, b, c) i wypisujący na ekranie jej miejsca zerowe lub informację o ich
        braku.
        Wskazówka: Zbadaj deltę, wyznacz miejsca zerowe*/
        public static void Zadanie9()
        {
            Console.WriteLine(" Podaj współczynniki funkcji kwadratowej f(x) = ax^2 + bx + c");

            Console.WriteLine("Podaj współczynnik a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            int bSqrt = (int)Math.Pow(b, 2);
            int ac4 = 4 * a * c;

            double delta = bSqrt - ac4;

            double licznik, mianownik, x1, x2;
            switch (delta)
            {
                case > 0:
                    b = -b;
                    delta = (double)Math.Sqrt(delta);

                    licznik = b - delta;
                    mianownik = 2 * a;
                    x1 = licznik / mianownik;

                    licznik = b + delta;
                    mianownik = 2 * a;
                    x2 = licznik / mianownik;

                    Console.WriteLine($"Miejsca zerowe tej funkcji to x1 = {x1} i x2 = {x2}. ");
                    break;

                case 0:

                    mianownik = 2 * a;
                    x1 = -b / mianownik;

                    Console.WriteLine($"Miejsca styku z osią x tej funkcji to x = {x1}. ");
                    break;

                default:

                    Console.WriteLine($"Ta funkcja nie ma miejsc zerowych. ");
                    break;
            }
        }

        /*Napisać program wczytujący liczbę arabską od 1 do 1 000 000 i wypisujący na ekranie
        słownie wczytaną liczbę.
        Np.: wejście=105, wyjście=sto pięć.*/
        public static void Zadanie10()
        {
            Console.WriteLine("Podaj liczbe do przetlumaczenia: ");
            int numer = Convert.ToInt32(Console.ReadLine());

            string numerNaSlowo = numer.ToWords();

            Console.WriteLine($"Liczba {numer} słownie: {numerNaSlowo}");
        }
    }
}
