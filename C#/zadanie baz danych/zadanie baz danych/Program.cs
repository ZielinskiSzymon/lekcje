using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie_baz_danych
{
    internal class Program
    {

        public class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            string filePath = "dane.txt";

            List<Person> list = new List<Person>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string linia;

                    while ((linia = reader.ReadLine()) != null)
                    {
                        string[] data = linia.Split(',');

                        Person person = new Person
                        {
                            Firstname = data[0],
                            Lastname = data[1],
                            Age = int.Parse(data[2])
                        };

                        list.Add(person);
                    }
                }
                Console.WriteLine("Liczba osob w bazie: ");

                foreach (var person in list)
                    Console.WriteLine($"{person.Firstname} {person.Lastname} {person.Age}");
            } else Console.WriteLine("Plik nie istnieje!");
        }
    }
}
