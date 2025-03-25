using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakaca_zadanie
{
    abstract class Osoba
    {
        public string Imie
        {
            get;
            protected set;
        }
        public string Nazwisko
        {
            get;
            protected set;
        }

        public Osoba()
        {
            this.Imie = "";
            this.Nazwisko = "";
        }

        public Osoba(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        abstract public string Opis();
        virtual public void test()
        {
            Console.WriteLine("Klasa Osoba");
        }
        public static void wypiszElementy(Osoba[] osoby)
        {
            for (int i = 0; i < osoby.Length; i++)
            {
                if (osoby[i] != null)
                {
                    Console.WriteLine(osoby[i].Opis());
                    osoby[i].test();
                }
            }
        }
    }

    //Towrzymy klasy dziedziczace po klasie Osoba

    class Pracownik : Osoba
    {
        public double Wynagrodzenie
        {
            get;
            protected set;
        }

        public Pracownik() : base()
        {
            this.Wynagrodzenie = 0;
        }
        public Pracownik(string imie, string nazwisko, double wynagrodzenie) : base(imie, nazwisko)
        {
            this.Wynagrodzenie = wynagrodzenie;
        }

        public override string Opis()
        {
            return "Pracownik: " + this.Imie + " " + this.Nazwisko + " " + this.Wynagrodzenie;
        }

        public override void test()
        {
            Console.WriteLine("klasa Pracownik");
        }
    }

    class Student : Osoba
    {
        public byte Semestr
        {
            get;
            protected set;
        }

        public Student() : base()
        {
            this.Semestr = 0;
        }

        public Student(string imie, string nazwisko, byte semestr) : base(imie, nazwisko)
        {
            this.Semestr = semestr;
        }

        public override string Opis()
        {
            return "Student: " + this.Imie + " " + this.Nazwisko + " " + this.Semestr;
        }

        public override void test()
        {
            Console.WriteLine("klasa Student");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Pracownik("Jan", "Kowalski", 3000);
            Console.WriteLine(o.Opis());
            o.test();

            Osoba[] osoby = new Osoba[4];

            osoby[0] = new Pracownik("Jan", "Kiszka", 5000);
            osoby[1] = new Pracownik("Tadek", "Niejadek", 13000);
            osoby[2] = null;
            osoby[3] = null;


            Osoba.wypiszElementy(osoby);
        }
    }
}