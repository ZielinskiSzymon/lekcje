using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty
{
    class Wektor
    {
        double x, y, z;
        string nazwa; // pola prywatne - wsp wektora [x,y,z]
        //metody publiczne 
        public Wektor()//konsturuktor bez parametor
        {
            x = 0; y = 0; z = 0; nazwa = "";
        }
        public Wektor(string nazwa, double x, double y, double z)
        {
            this.nazwa = nazwa;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Czytaj()
        {
            Console.Write("podaj nazwa=");
            nazwa = Console.ReadLine();

            Console.Write("podaj x=");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj y=");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("podaj z=");
            z = Convert.ToDouble(Console.ReadLine());
        }
        public void Wyswietl()
        {
            Console.WriteLine("[{0}, {1}, {2}, {3}]", nazwa, x, y, z);
        }
        public double DlugoscWektora()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public bool CzyRowne(Wektor w)
        {
            return x.Equals(w.x) && y.Equals(w.y) && z.Equals(w.z);
        }
        public bool CzyRozne(Wektor w)
        {
            return !this.CzyRozne(w);
        }
        public Wektor SumaWektorow(Wektor w)
        {
            Wektor temp = new Wektor();
            temp.nazwa = "w3";
            temp.x = x + w.x;
            temp.y = y + w.y;
            temp.z = z + w.z;
            return temp;
        }
        public Wektor DluzszyWektor(Wektor w)
        {
            if (w.DlugoscWektora() > this.DlugoscWektora())
            {
                return w;
            }
            else
            {
                return this;
            }
        }
        public string PodajNazwe()
        {
            return nazwa;
        }
    }// koniec klasy wektor

    class Koszyk
    {
        Wektor[] wektorki = new Wektor[4];
        int ilosc;

        public void wlozDoWektorkow(Wektor w)
        {
            wektorki[ilosc] = w;
            ilosc++;
        }
        public void podajWektorki()
        {
            foreach (var wektor in wektorki)
            {
                Console.WriteLine("Wektor Nazwa " + wektor.PodajNazwe() + " Dlguosc wektora: " + Math.Round(wektor.DlugoscWektora()));
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Koszyk koszyk = new Koszyk();

            Wektor w1 = new Wektor("w1", 5, 6, 7);
            Console.Write("w1=");
            w1.Wyswietl();

            Wektor w2 = new Wektor(), w4;
            w2.Czytaj();
            Console.Write("w2=");
            w2.Wyswietl();

            Wektor w3 = new Wektor();

            w3 = w1.SumaWektorow(w2);
            Console.Write("w3=");
            w3.Wyswietl();
            if (w2.CzyRowne(w1)) Console.WriteLine("w1==w2");
            else Console.WriteLine("w1!=w2");

            w4 = new Wektor();
            w4 = w1.DluzszyWektor(w2);
            Console.Write("w4=");
            w4.Wyswietl();

            koszyk.wlozDoWektorkow(w1);
            koszyk.wlozDoWektorkow(w3);
            Console.WriteLine("Aktualnie w koszyku: ");
            koszyk.podajWektorki();

        }
    }
}