using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odwracanie_tablicy_rekurencyjnie
{
    internal class Program
    {
        public static void zamianaliczb(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        public static void obracanieTablicy(ref int[] tab, int i)
        {
            if (i >= tab.Length / 2)
                return;

            zamianaliczb(ref tab[i], ref tab[tab.Length - 1 - i]);
            obracanieTablicy(ref tab, i + 1);
        }
        static void Main(string[] args)
        {
            int[] tab = { 5, 9, 7, 8, 17, 20, 30 };


            foreach (int i in tab) 
                Console.Write(i+", ");

            Console.WriteLine();

            obracanieTablicy(ref tab, 0);           

            foreach(int i in tab) 
                Console.Write(i+", ");

            Console.WriteLine();

        }
    }
}
