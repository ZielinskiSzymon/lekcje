using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._09._2024_ciag_daszy
{
    internal class Program
    {
        class Przyklad
        {
            private int liczba = 12; // liczba (pole prywatne) - male liczby
            public int Liczba // Liczba (publiczna wlasciwosc) - pierwsza duza litera
            {
                get { return liczba; }
                set { liczba |= value; }
            }
        }
        static void Main(string[] args)
        {
            Przyklad p1 = new Przyklad();
            //  Console.WriteLine("miesiac: "+p1.liczba);  blad prywatne pole
            Console.WriteLine("miesiac: "+p1.Liczba); 
        }
    }
}
