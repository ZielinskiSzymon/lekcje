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

            // Tworzenie pliku i zapisywanie danych

            using(StreamWriter writer= new StreamWriter(filePath, true))
            {
                writer.WriteLine("Linia 1: CSGO - skins.com");
                writer.WriteLine("Linia 2: Cosik");
                writer.WriteLine("Linia 3: Nie mam pomysłu");
            }
            Console.WriteLine("Dane zostały zapisane do pliku");
        }
    }
}
