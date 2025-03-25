using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin_inf04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Podaj a->");
            a = int.Parse(Console.ReadLine());

            Console.Write("Podaj b->");
            b = int.Parse(Console.ReadLine());

           if(a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
