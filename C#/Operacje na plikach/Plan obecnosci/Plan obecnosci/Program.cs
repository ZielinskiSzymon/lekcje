using System;
using System.IO;

namespace Plan_obecnosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";

            while (true)
            {
                Console.Write("Podaj imię i nazwisko ucznia (lub wpisz 'koniec' aby zakończyć) -> ");
                string imieNazwisko = Console.ReadLine();

                if (imieNazwisko.ToLower() == "koniec")
                {
                    break;
                }

                Console.Write("Czy uczeń jest obecny? (t/n) -> ");
                char obecny = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (obecny != 't' && obecny != 'n')
                {
                    Console.WriteLine("Nieprawidłowa odpowiedź. Wprowadź 't' lub 'n'.");
                    continue;
                }

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string status = obecny == 't' ? "Obecny" : "Nieobecny";
                    writer.WriteLine($"{imieNazwisko}: {status}");
                }
            }

            Console.Write("\nCzy chcesz wyświetlić zawartość pliku? (t/n): ");
            char decyzja = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (decyzja == 't' || decyzja == 'T')
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        Console.WriteLine("\nLista uczniów:");
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nie znaleziono pliku!");
                }
            }
            else
            {
                Console.WriteLine("Zakończono bez wyświetlania zawartości pliku.");
            }
        }
    }
}
