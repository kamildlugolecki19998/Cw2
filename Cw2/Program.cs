using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {

            // sprawdzenie czy liczba jest parzysta czy ujemna  zad 3.a
            //    Console.WriteLine("podaj licznę :");
            //    int liczba = Convert.ToInt32(Console.ReadLine());
            //    if (liczba %2 == 0)
            //    {
            //        Console.WriteLine("Liczba jest parzysta");


            //    }
            //    else
            //    {
            //        Console.WriteLine("Liczba nieparzysta");
            //    }
            //    if (liczba < 0)
            //    {
            //        Console.WriteLine("Liczba ujemna");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Liczba Dodatnia");
            //    }


            //zad 3.b 



            //Console.WriteLine("Podaj pierwszą liczbe odwierającą przedział");
            //int liczba_o = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj liczbe zamykajaca przedzial");
            //int liczba_z = Convert.ToInt32(Console.ReadLine());
            //for (int i = liczba_o; i < liczba_z; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        Console.Write(i + ",");
            //    }
            //}

            // splata dlugu 


            //int i = 1;
            //double dlug = 80;
            //double zarobki_janka = 50, zarobki_karola = 40;
            //double splata = 0;

            //do
            //{
            //    splata += 0.2 * zarobki_janka + 0.2 * zarobki_karola;

            //    Console.WriteLine("Dzien {1} ilosc odlozonych pieniedzy {0}  ", splata, i);
            //    i++;
            //} while (splata <= dlug);

            // rysowanie kwadratu 
            //Console.WriteLine("Podaj wilekosc kwadratu");
            //int bok = Convert.ToInt16(Console.ReadLine());
            //for (int i = 1; i <= bok; i++)
            //{

            //    for (int j = 1; j <= bok; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}
            //zad 3.1 czy rok jest przestepny
            //Console.WriteLine("Podaj rok ");
            //int rok = Convert.ToInt32(Console.ReadLine());
            //if (rok % 4 == 0 && (rok % 100 != 0 || rok % 400 == 0))
            //{
            //    Console.Write("rok jest przestepny");
            //}
            //else
            //{
            //    Console.Write("Rok nie jest przestepny");
            //}

            // zad 3.2

            //Console.WriteLine("podaj liczbe ");
            //int liczba1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("podaj 2 liczbe");
            //int liczba2 = Convert.ToInt32(Console.ReadLine());

            //if (liczba1 > liczba2)
            //{
            //    if (liczba1 %liczba2 ==0)       
            //    {
            //        Console.WriteLine("Liczba {0}, jest dzielniekniem liczby{1}", liczba2, liczba1);
            //    }
            //    else
            //    {
            //             Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", liczba2, liczba1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Liczba {0} jest mniejsza od {1}", liczba2, liczba1);
            //}
            // zad 3.3 porownaywanie 3 liczb

            //Console.WriteLine("Podaj liczbe ");
            //int liczba1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj liczbe ");
            //int liczba2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Podaj liczbe ");
            //int liczba3 = Convert.ToInt32(Console.ReadLine());
            //if (liczba1 > liczba2 && liczba1 > liczba3)
            //{
            //    Console.WriteLine("Liczba {0} jest najwieksza", liczba1);

            //}
            //else if (liczba2 > liczba3)
            //{
            //    Console.WriteLine("Liczba {0} jest najwieksza", liczba2);
            //}
            //else
            //{
            //    Console.WriteLine("Liczba{0} jest najwieksza", liczba3);
            //}

            // kalkulator  zad 3.4

            Console.WriteLine("Podaj liczbe");
            double liczba = Convert.ToDouble(Console.ReadLine());
            //double liczba = (double)Console.ReadLine();
            Console.WriteLine("Podaj liczbe");
            double liczba1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj zank +, - ,* , /");
            string znak = Console.ReadLine();
            switch (znak)
            {
                case : znak == "+" 

                default:
                    break;
            }


            Console.ReadKey();

        }



    }
}
