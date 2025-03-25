using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_blokow_w_binarnych
{
    internal class Program
    {
        static String zmianaNaBinarne(int num)
        {
            if (num == 0) return "0";

            String binarna = "";

            while (num > 0)
            {
                binarna = (num%2) + binarna;
                num/=2;
            }


            return binarna;
        }
        static int ileBlokow(String binarna)
        {
            Char znak;
            int zmiany = 1;
            for (int i = 0; i < binarna.Length - 1; i++)
            {
                znak = binarna[i];

                if (znak != binarna[i + 1])
                    zmiany++;
            }

            return zmiany;
        }
        static void Main(string[] args)
        {
            int num = 3451;
            String numBinarna = zmianaNaBinarne(num);
            Console.WriteLine(numBinarna);
            Console.WriteLine("Blokow: "+ileBlokow(numBinarna));
        }
    }
}
