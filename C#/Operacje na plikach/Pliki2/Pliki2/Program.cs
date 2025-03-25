using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sciezka do pliku
            string filePath = "example.txt";

            // Sprawdzanie czy plik istnieje

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else Console.WriteLine("Niez znaleziono pliku!");

        }
    }
}
