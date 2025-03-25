using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odczyt
{
    internal class Program
    {
            //plik tekstowy - zapisam\ny za pomoca kodowanie Unicode
            //plik binarny - zapaisany w postaci binarnej, np obrazek.
            //dane zapisane w tym pliku przeznaczone dla programu ktore je utworzyl
            //plik tekstowy - zpaisany w postaci tekstu plik.txt dane zapisane
            //w tym pliku moha byc odczytane przez czlowieka
        static void Main(string[] args)
        {

            //Zapis
            try
            {
                        //StreamWriter outputfile = File.CreateText("plik.txt"); // Otwiera plik do zapisu

                //outputfile.WriteLine("Hello World!");
                //outputfile.WriteLine("Informatyka");
                //outputfile.WriteLine("Uniwersytet Warszawski");
                //outputfile.WriteLine("Muzyka");



                        //Dołączenie danych do istniejacego pliku

                //StreamWriter outputfile = File.AppendText("plik.txt");

                //outputfile.WriteLine("Królik");
                //outputfile.WriteLine("Rudy");

                //outputfile.Close();



                        
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            // Odczyt
            try
            {
                StreamReader inputfile;
                inputfile = File.OpenText("plik.txt");
                string line;

                while ((line = inputfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
    }
}
