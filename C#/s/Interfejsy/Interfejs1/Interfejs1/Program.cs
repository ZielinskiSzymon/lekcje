using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaejsy
{
    internal class Program
    {

        //Interfejsy przypominaja klasy abstrakcyjne, moga zawierac jedynie deklaracje metod, 
        // właściwości, indeksery i zdarzenia. Nie zawiera pol, konstruktorow, destruktorow , operatorow

        interface IZycie
        {
            void Oddychanie();
            void Poruszanie();
        }

        class Ryba : IZycie
        {
            public void Oddychanie()
            {
                Console.WriteLine("Ryba oddycha skrzelami.");
            }
            public void Poruszanie()
            {
                Console.WriteLine("Ryba tylko pływa.");
            }
        }

        class Ssak : IZycie
        {
            public void Oddychanie()
            {
                Console.WriteLine("Ssak oddycha płucami.");
            }
            public void Poruszanie()
            {
                Console.WriteLine("Ssak biega");
            }
        }
        static void Main(string[] args)
        {
            Ryba ryba = new Ryba();
            Ssak ssak = new Ssak();
            IZycie[] zycie = { ryba, ssak };

            foreach (IZycie element in zycie)
            {
                element.Oddychanie();
                element.Poruszanie();
            }
        }
    }
}
