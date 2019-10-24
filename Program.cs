using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy
{
    class Program
    {
        static void NaszaMetoda(int x)
        {

        }
        //static void Odejmij(int x, int y)
        //{
        //    Console.WriteLine(x - y);
        //}
        static double Dziel(double x, int y)
        { double wynik = 0;
            if (y != 0)
            {
                wynik = x / y;
            }
            return (wynik);
        }
        static void Dodaj(int a)
        {
            a++;
            Console.WriteLine("Argument z wnetrza metody: " + a);

        }
        static void DodajR(ref int a)
        {
            a++;
            Console.WriteLine("argument  z wnetrza metody" + a);

        }
        static void DodajO (out int x, out int y)
        {
            x = 2;
            y = 5;
            Console.WriteLine("Dodaj(): x = {0}  y = {1}", x, y);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Dziel(1.5, 3));
            //Odejmij(4, 3);
            //double wynik;
            //wynik = Dziel(1.5, 3);
            //Console.WriteLine(wynik); // przyklad wywolania metody gdyby wynik miaby byc wykorzystany w innym miejscu programu
            // wynik jest mnozony przez 2 a zatem uzyty w wyrazeniu iloczyn ten jest argumentem dla metody console.write()
            //Console.WriteLine(Dziel(1.5, 3) * 2);
            //double x = 0.5;
            //int y = 4;
            //Console.WriteLine(Dziel(x, y)); //uzycie zmiennych jako argumentow nie sa one powiazane z tymi w nazwami argumentow definicji metody
            // metoda dodaj przekazanie przez wartosc 
            //int x = 5;
            //Console.WriteLine("Przed wywolaniem metody: " + x);
            //Dodaj(x);
            //Console.WriteLine("Po wykonaniu metody :" + x);

            // metoda Dodaj przekazanie przez referencje (adres praca na orginalnych danych)
            //int x = 5;
            //Console.WriteLine("Argument przed wywolaniem metody" + x);
            //DodajR(ref x);
            //Console.WriteLine("Po " + x);
            int a, b;
            DodajO(out a, out b);
            Console.WriteLine("Main(): a={0}  b={1}", a, b);




            Console.ReadKey();
        }
    }
}
