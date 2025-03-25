using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    internal class Program
    {
        //Struktura jest typem wartosciowym (klasa referencyjnym)
        //Struktura nie moze dzidziczyc po klasie,a nie moze byc przedmiotem dziedziczenia
        //Nie obsluguja destruktorow
        //Nie mozna zadeklarowac konstrukora bez argumentow
        //Skladowe nie moga byc inicjalozowane w momecie deklarowania
        //Różnica w składni - slowo kliczowe struct
        static void Main(string[] args)
        {
            DateTime T1 = DateTime.Now;
            Console.WriteLine("Czas poczatkowy T1: {0}", T1);
            int Licznik=0;
            for (int i = 0; i < int.MaxValue; i++)
                Licznik++;
            Console.WriteLine("Wartosc zmiennej Licznik: {0}",Licznik);
            DateTime T2 = DateTime.Now;
            Console.WriteLine("Czas koncowy T2: {0}", T2);
            Console.WriteLine("Roznica T2-T1: {0}",T2 - T1);
            Console.WriteLine("Dzis jest {0} dzien roku", T1.DayOfYear);
        }
    }
}
