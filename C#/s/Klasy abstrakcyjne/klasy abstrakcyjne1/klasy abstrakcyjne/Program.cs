using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_abstrakcyjne
{
    internal class Program
    {
        abstract class Zwierzak
        {
            public string nazwa;
            public abstract void Oddychanie();
        }
        class Ryba : Zwierzak
        {
            public Ryba (string nazwa)
            {
                this.nazwa = nazwa;
            }

            public override void Oddychanie()
            {
                Console.WriteLine($"Ryba {nazwa} oddycha za pomoca skrzeli");
            }
        }
        class Ssak : Zwierzak
        {
            public Ssak(string nazwa)
            {
                this.nazwa = nazwa;
            }
            public override void Oddychanie()
            {
                Console.WriteLine($"Ssak {nazwa} oddycha za pomoca płuc");

            }
        }
        static void Main(string[] args)
        {
            // Klasa abstrakcyjna - nie można tworzyc obiektów tej klasy
            // Klasa abstrakcyjna może zawierać metody abstrakcyjne
            // Metoda abstrakcjna nie posiada ciala
            // Klasa dziedziczącapo klasie abstrakcyjnej musi zaimplementowac wszystkie
            // metody abstrakcyjne
            // Klasy abstrakyjna może zawierać metody wirtualne
            // Klasa taka ma sens w przypadku, gdy kilka klas pochodnych wymaga 
            // uzycia tej samej metody ale z różna implementacja
            // Klasa abstrakcyjna może zawierać pola

            Ryba ryba = new Ryba("Rekin");
            Ssak ssak = new Ssak("Kot");

            ryba.Oddychanie();
            ssak.Oddychanie();
        }
    }
}
