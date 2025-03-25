using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzamin_30._09._2024
{
    internal class Program
    {
        public static void checkSex(string pesel)
        {
            int lenght = pesel.Length - 1;
            

            if (pesel[lenght-1]%2 != 0)
                Console.WriteLine("M");
            else
                Console.WriteLine("K");
        }
        public static bool checkWeight(string pesel)
        {
            int[] weight = { 1,3,7,9,1,3,7,9,1,3 };
            int S=0,M=0,R=0;
            int lenght = pesel.Length-1;
            
            for (int i = 0; i < lenght; i++)
            {
                S += int.Parse(pesel[i].ToString()) * int.Parse(weight[i].ToString());
            }

            M = S % 10;

            if (M == 0)
                R = 0;
            else
                R = 10 - M;


            if (R == int.Parse(pesel[lenght].ToString()))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string pesel = "07960556969";



            checkSex(pesel);
            if (checkWeight(pesel))
                Console.WriteLine("Poprawny pesel");
            else Console.WriteLine("Niepoprawny pesel");
            
        }
    }
}
