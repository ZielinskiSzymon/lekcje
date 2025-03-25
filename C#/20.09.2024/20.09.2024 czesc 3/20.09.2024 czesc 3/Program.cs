using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._09._2024_czesc_3
{
    internal class Program
    {
        class Przyklad
        {
            private int godzina;
            public int Godzina
            {
                get { return godzina; }
                set
                {
                    if (value >= 0 && value <= 24)
                    {
                        godzina = value;
                    }
                    else godzina = 0;
                }
            }
            public string Info()
            {
                return "jest godzina " + godzina;
            }
        }

        class Student
        {
            private string nazwisko = "";
            private long numerIndeksu = 0;
            public string Nazwisko
            {
                get { return nazwisko; }
                set { nazwisko = value; }
            }
            public long NumerIndeksu
            {
                get { return numerIndeksu; }
                set
                {
                    if (value < 0 || value > 999999999) numerIndeksu = 0;
                    else numerIndeksu = value;
                }
            }
        }

        class P1
        {
            public P1()
            {
                Console.WriteLine("Tworze nowy obiekt");
            }
            static public void Metoda_statyczna()
            {
                Console.WriteLine("Metoda statyczna");
            }
        }
        static void Main(string[] args)
        {
            //Przyklad p = new Przyklad();
            //p.Godzina = 13;
            //Console.WriteLine(p.Info());


            //Student s =new Student();
            //s.Nazwisko = "Kowalski";
            //s.NumerIndeksu = 12312;
            //Console.WriteLine("Student: " + s.Nazwisko + ", numer indeksu " + s.NumerIndeksu);

            P1.Metoda_statyczna();
            P1 p1 = new P1();
            //p1.Metoda_statyczna();  To nie działa
        }
    }
}
