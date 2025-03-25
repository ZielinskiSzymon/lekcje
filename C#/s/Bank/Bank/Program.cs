using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontoBankowe
{
    //konto bankowe aby fal kazdego bylo takie same nazwy itp dla wszystkich bakow
    //kazde kono bedzie implemtowac Ikontobankowe
    interface IKontoBankowe
    {
        //nie mozemy teorzyc konstruktow\ro ani zmiennych 
        void Wplac(decimal ilosc);
        bool Wyplac(decimal ilosc);
        decimal Saldo { get; }
        bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc);
    }

    class KontoA : IKontoBankowe
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
        }

        public void Wplac(decimal ilosc)
        {
            saldo += ilosc;
        }

        public bool Wyplac(decimal ilosc)
        {
            if (saldo >= ilosc)
            {
                saldo -= ilosc;
                return true;
            }
            else
            {
                Console.WriteLine("Brak srodkow na koncie");
                return false;
            }
        }

        public bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc)
        {
            bool wyplacono = this.Wyplac(ilosc);
            if (wyplacono)
                cel.Wplac(ilosc);
            return wyplacono;
        }
    }

    class KontoB : IKontoBankowe
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
        }

        public void Wplac(decimal ilosc)
        {
            saldo += ilosc;
        }

        public bool Wyplac(decimal ilosc)
        {
            if (saldo >= ilosc)
            {
                saldo -= ilosc;
                return true;
            }
            else
            {
                Console.WriteLine("Brak srodkow na koncie");
                return false;
            }
        }

        public bool PrzetransferujDo(IKontoBankowe cel, decimal ilosc)
        {
            bool wyplacono = this.Wyplac(ilosc);
            if (wyplacono)
                cel.Wplac(ilosc);

            return wyplacono;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int kwota;
            char konto1 , konto2;
            IKontoBankowe a = new KontoA();
            IKontoBankowe b = new KontoB();
            a.Wplac(10000);
            b.Wplac(5000);


            Console.Write("Jaka kwote chcesz przelac -> ");
            kwota = int.Parse(Console.ReadLine());
            Console.Write("Z jakiego konta(a,b) -> ");
            konto1 = char.Parse(Console.ReadLine());


            switch (konto1) {
                case 'a':
                    a.PrzetransferujDo(b, kwota);
                    break;
                case 'b':
                    b.PrzetransferujDo(a, kwota);
                    break ;
            }


            Console.WriteLine("Saldo konta A: " + a.Saldo);
            Console.WriteLine("Saldo konta B: " + b.Saldo);
        }
    }
}