using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejs3
{
    internal class Program
    {
        interface IAtakMagiczny
        {
            void atak(int obrazenia);
        }
        interface IAtakMieczem
        {
            void atak(int obrazenia);
        }

        class Postac : IAtakMagiczny, IAtakMieczem
        {
            public string imie;
            public int puktyZycia;

            public Postac (string imie, int puktyZycia)
            {
                this.imie = imie;
                this.puktyZycia = puktyZycia;
            }

            void IAtakMieczem.atak(int obrazenia)
            {
                Console.WriteLine($"Atak mieczem: {obrazenia}");
            }
            void IAtakMagiczny.atak(int obrazenia)
            {
                Console.WriteLine($"Atak magiczny: {obrazenia}");
            }
        }
        static void Main(string[] args)
        {
            Postac postac = new Postac("Jan", 100);
            IAtakMagiczny atak1 = (IAtakMagiczny)postac;
            atak1.atak(10);
            IAtakMieczem atak2 = (IAtakMieczem)postac;
            atak2.atak(20);
        }
    }
}
