using System;

namespace klasy_abstrakcyjne3
{
    internal class Program
    {
        abstract class Osoba
        {
            public abstract string getName();
            public abstract string getSurname();
            public abstract void wypisz();
        }

        class Pracownik : Osoba
        {
            public double wynagrodzenie { get; set; }

            public override string getName()
            {
                return "Adam";
            }

            public override string getSurname()
            {
                return "Mickiewicz";
            }

            public Pracownik()
            {
                Console.Write("Podaj wynagrodzenie -> ");
                wynagrodzenie = int.Parse(Console.ReadLine());
            }

            public override void wypisz()
            {
                Console.WriteLine($"\nImie: {getName()},\nNazwisko: {getSurname()},\nWynagrodzenie: {wynagrodzenie}");
            }
        }

        class Student : Osoba
        {
            public int semestr { get; set; }

            public override string getName()
            {
                return "Michał";
            }

            public override string getSurname()
            {
                return "Zajac";
            }

            public Student()
            {
                Console.Write("\nPodaj semestr -> ");
                semestr = int.Parse(Console.ReadLine());
            }

            public override void wypisz()
            {
                Console.WriteLine($"\nImie: {getName()},\nNazwisko: {getSurname()},\nSemestr: {semestr}");
            }
        }

        static void Main(string[] args)
        {
            Pracownik pracownik = new Pracownik();
            pracownik.wypisz();

            Student s = new Student();
            s.wypisz();
        }
    }
}
