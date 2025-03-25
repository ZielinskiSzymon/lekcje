using System;
class Program
{
    static void Main()
    {
        Console.Write("Liczby pierwsze od 2 do 100 -> ");
        for (int i = 2; i <= 100; i++)
        {
            if (CzyPierwsza(i))
            {
                Console.Write(i + ", ");
            }
        }
    Console.WriteLine();
    }
    static bool CzyPierwsza(int liczba)
    {
        if (liczba < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}