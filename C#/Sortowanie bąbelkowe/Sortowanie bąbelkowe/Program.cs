using System;

class Program
{
    static void BoobleSort(int[] tablica)
    {
        int n = tablica.Length;
        bool zamieniono;

        for (int i = 0; i < n - 1; i++)
        {
            zamieniono = false;

            for (int j = 0; j < n - 1 - i; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;
                    zamieniono = true;
                }
            }

            if (!zamieniono)
                break;
        }
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (var element in tablica)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] tablica = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Tablica przed posortowaniem:");
        WypiszTablice(tablica);

        BoobleSort(tablica);

        Console.WriteLine("Tablica po posortowaniu:");
        WypiszTablice(tablica);
    }

}