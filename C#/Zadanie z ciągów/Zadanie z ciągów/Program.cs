using System;
using System.IO;

namespace ciagi
{
    internal class Program
    {
        static StreamReader firstInput = new StreamReader("ciagi.txt");
        static StreamWriter firstOutPut = new StreamWriter("wynik1.txt");

        static int highestDiference = 0;

        public static bool isArithmetical(int[] array)
        {
            int difference = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 1)
                    difference = array[i] - array[i - 1];
                else if (i != 0)
                    if (difference != (array[i] - array[i - 1]))
                        return false;
            }
            if (difference > highestDiference)
                highestDiference = difference;

            return true;
        }
        static void Main(string[] args)
        {

            int arithmeticCount = 0;
            while (!firstInput.EndOfStream)
            {
                int length = int.Parse(firstInput.ReadLine());
                int[] array = new int[length];
                string[] arrayNumbersRaw = firstInput.ReadLine().Split(' ');

                for (int i = 0; i < length; i++)
                {
                    array[i] = int.Parse(arrayNumbersRaw[i]);
                }

                if (isArithmetical(array)) arithmeticCount++;

            }
            Console.WriteLine(arithmeticCount);
            Console.WriteLine(highestDiference);
        }
    }
}