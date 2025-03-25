using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            StreamWriter parzyste;
            parzyste = File.CreateText("parzyste.txt"); 
            StreamWriter nieparzyste;
            nieparzyste = File.CreateText("nieparzyste.txt");

            int num,
                parzysteL = 0,
                nieparzysteL = 0;
            for (int i = 0; i < 100; i++)
            {
                num = rnd.Next(1000);

                if(num%2 == 0)
                {
                    parzyste.WriteLine(num);
                    parzysteL++;
                }
                else
                {
                    nieparzyste.WriteLine(num);
                    nieparzysteL++;
                }
            }
            Console.WriteLine($"Parzyste: {parzysteL}, Nieparzyste: {nieparzysteL}");
        }
    }
}
