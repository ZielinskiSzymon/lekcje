using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._09._2024_czesc_4
{
    // Metoda virtualna - jest przygotowana do zasąpienia jej innm kodem w klasie potomnej metode tworzmy za pomoca slowa kluczowego virtual
    internal class Program
    {
        class Zwierzak
        {
            public int Wiek;
            public virtual void Oddychanie()
            {
                Console.WriteLine("Zwierzak oddycha...");
            }
        }
        class Ssak : Zwierzak
        {
            public override void Oddychanie()
            {
                Console.WriteLine("Ssak oddycha plucami ....");
            }
        }
        class Ryba : Zwierzak
        {
            public override void Oddychanie()
            {
                Console.WriteLine("Ryba oddycha skrzelami ....");
            }
        }
        static void Main(string[] args)
        {
            Zwierzak zwierz;

            Console.WriteLine("\n1 - tworz obiekt klasy Ssak");
            Console.WriteLine("\n2 - tworz obiekt klasy Ryba");
            Console.WriteLine("\n3 - tworz obiekt klasy Zwierzak");

            // wcytamy znaki z konsoli i przypiszemy gdo obiektu klasy ConsoleInfo

            ConsoleKeyInfo Key =Console.ReadKey();

            switch(Key.KeyChar)
            {
                case '1' : zwierz = new Ssak(); break;
                case '2' : zwierz = new Ryba(); break;
                default: zwierz = new Zwierzak(); break;
            }

            zwierz.Oddychanie();
        }
        // z hierarchi dziedziczenia wynika, iz kazdy obiekt klasy pochodej jest jednoczescnie obiektem klasy bazowej (np. ryba to zwierz)

        // Metoda statyczna nie moze byc virtualna. Metody wirtuale sa wykonywane na recz obiektu klasy, a metda statyczna zwiazana jest z istnieniem samej klasy i mnie moze byc wolna z jej obiektu.
    }
}
