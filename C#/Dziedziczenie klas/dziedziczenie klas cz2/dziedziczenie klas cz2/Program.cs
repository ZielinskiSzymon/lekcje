using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie_klas_cz2
{
    class Figura
    {
        protected string nazwa;
        public Figura(){nazwa = "Anonim";}
        public Figura(string nazwa){this.nazwa = nazwa;}
        public virtual void Wyswietl() { Console.WriteLine("\nFigura: "+nazwa);}
    }

    class Kwadrat : Figura
    {
        protected double a = 1;
        public Kwadrat() { nazwa = "Kwadrat"; }
        public Kwadrat(String k) : base(k) { }
        public Kwadrat(string k,double bok) : base(k) {  a = bok;}

        public virtual double ObliczPole() { return a * a; }
        public override void Wyswietl()
        {
            Console.WriteLine("\nKwadrat: "+nazwa+" bok: "+a+" pole: "+ObliczPole());
        }
    }

    class Prostokat : Kwadrat
    {
        protected double b = 1;
        public Prostokat() { nazwa = "Prastakat"; }
        public Prostokat(string k) : base(k) { }
        public Prostokat(string k, double bok1, double bok2) : base(k)
        {
            a = bok1;
            b = bok2;
        }
        public override double ObliczPole() { return a * b; }
        public override void Wyswietl()
        {
            Console.WriteLine("\nProstakoat: " + nazwa + " bok1: " + a + " bok2: " + b + " pole: " + ObliczPole());
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Figura();
            Kwadrat k1 = new Kwadrat("Kw1",5);
            Kwadrat k2 = new Kwadrat("Kw2", 10);
            Prostokat p1 = new Prostokat("P1", 5, 10);
            Prostokat p2 = new Prostokat("P2", 10, 20);

            Figura[] figury =
            {
                f,k1,k2,p1,p2
            };
            foreach (var fig in figury) {
                fig.Wyswietl();
            }
        }
    }
}
