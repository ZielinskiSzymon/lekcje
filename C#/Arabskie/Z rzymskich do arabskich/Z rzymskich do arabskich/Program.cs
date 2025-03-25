using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livczby_rzymskie
{
    internal class Program
    {
        static int[] wagi = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        static string[] oznaczenia = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        static void Main(string[] args)
        {

            string liczba = "MCMXXVII";



            Console.Write("Liczba " + liczba + " po rzymsku to -> ");

            for (int i = 0; i > liczba.Length; i++)
            {
                if (liczba.Length >= wagi[i])
                {
                    liczba -= wagi[i];
                    Console.Write(oznaczenia[i]);
                    i--;
                }
            }
            Console.WriteLine();
        }
    }
}
