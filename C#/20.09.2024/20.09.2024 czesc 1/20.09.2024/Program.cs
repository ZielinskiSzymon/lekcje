using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Składniki statyczne klasy

//      1.Klasy - sa ładowane do pamięci w momencie gody ładowany jest program lub przestrzen nazw ktora ją zawiera
//      2.Metody - sa zwiazane z samą klasa(nie musi istniec obiekt klasy aby mozna było skorzystac z metody Statcznej)
//      3. Właściwosci analoogiczne jak metody




namespace _20._09._2024
{
    internal class Program
    {
        class A
        {
            public void Run()
            {
                Console.WriteLine("Metoda Run() z klasy A");
            }
        }
        class B : A
        {
            new public void Run() // swiadome przesloniecie metody badklasy
            {
                base.Run();
                Console.WriteLine("Metoda Run() z klasy B");
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            b.Run();
        }
    }
}
