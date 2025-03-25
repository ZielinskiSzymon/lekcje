using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static klasy_abstrakcyjne2.Program;

namespace klasy_abstrakcyjne2
{
    internal class Program
    {
        public abstract class ProductToSell
        {
            public abstract string getName();
            public abstract double getPrice();
            public abstract int getPercentDiscount();
            public abstract string getCategory();

            public string getWarehous()
            {
                return "Magazyn nr 1";
            }
        }
        public class Book : ProductToSell
        {
            public override string getName()
            {
                return "Potop";
            }
            public override double getPrice()
            {
                return 50.0;
            }
            public override int getPercentDiscount()
            {
                return 10;
            }
            public override string getCategory()
            {
                return "Ksiażki";
            }
        }
        public class Cup : ProductToSell
        {
            public override string getName()
            {
                return "Kubek Programisty";
            }
            public override double getPrice()
            {
                return 15.5;
            }
            public override int getPercentDiscount()
            {
                return 7;
            }
            public override string getCategory()
            {
                return "Kubki";
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
            Console.WriteLine("Magazyn: " + book.getWarehous());
            Console.WriteLine();
            Console.WriteLine("Nazwa: " + cuo.getName());
            Console.WriteLine("Cena: " + cuo.getPrice());
            Console.WriteLine("Procent zniżki: " + cuo.getPercentDiscount());
            Console.WriteLine("Kategoria: " + cuo.getCategory());
            Console.WriteLine("Magazyn: " + cuo.getWarehous());
        }
    }
}
