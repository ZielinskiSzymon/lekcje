using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs2
{
    internal class Program
    {
        interface IProductToSell
        {
            string getName();
            double getPrice();
            int getPercentDiscount();
            string getCategory();
            string getWarehouse();
        }

        public class Book : IProductToSell
        {
            public string getName()
            {
                return "Prawdziwa historia Zielonki";
            }
            public double getPrice()
            {
                return 29.99;
            }
            public int getPercentDiscount()
            {
                return 5;
            }
            public string getCategory()
            {
                return "Ksiazka";
            }
            public string getWarehouse()
            {
                return "Magazyn 1";
            }
        }

        public class Cup : IProductToSell
        {
            public string getName()
            {
                return "Kubek Rudego";
            }
            public double getPrice()
            {
                return 9.99;
            }
            public int getPercentDiscount()
            {
                return 5;
            }
            public string getCategory()
            {
                return "Kubki";
            }
            public string getWarehouse()
            {
                return "Magazyn 2";
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Cup cuo = new Cup();
            Console.WriteLine("Nazwa: " + book.getName());
            Console.WriteLine("Cena: " + book.getPrice());
            Console.WriteLine("Procent zniżki: " + book.getPercentDiscount());
            Console.WriteLine("Kategoria: " + book.getCategory());
            Console.WriteLine("Magazyn: " + book.getWarehouse());
            Console.WriteLine();
            Console.WriteLine("Nazwa: " + cuo.getName());
            Console.WriteLine("Cena: " + cuo.getPrice());
            Console.WriteLine("Procent zniżki: " + cuo.getPercentDiscount());
            Console.WriteLine("Kategoria: " + cuo.getCategory());
            Console.WriteLine("Magazyn: " + cuo.getWarehouse());
        }
    }
}
