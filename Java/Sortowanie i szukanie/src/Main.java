import java.util.Random;
import java.util.Scanner;

public class Main {
    public static int[] Sortowanie(int[] tab){
        int n = tab.length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - 1 - i; j++) {
                if (tab[j] > tab[j + 1]) {
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                }
            }
        }
        return tab;
    }

    public static void Szukanie(int[] tab, int p, int k, int l){
        if (p >= k) {
            System.out.println("Nie znaleziono liczby w tablicy.");
            return;
        }

        int srodek = p + (k - p) / 2;

        if (tab[srodek] == l)
            System.out.println("Liczba została znaleziona na indeksie " + srodek);
        else if (tab[srodek] > l)
            Szukanie(tab, p, srodek, l);
        else
            Szukanie(tab, srodek + 1, k, l);
    }

    public static void main(String[] args) {
        Random random = new Random();
        Scanner scanner = new Scanner(System.in);
        int[] tab = new int[20];

        for (int i = 0; i < tab.length; i++) {
            tab[i] = random.nextInt(50);
        }

        tab = Sortowanie(tab);

        System.out.print("Podaj liczbe, którą mam sprawdzić -> ");
        int liczba = scanner.nextInt();

        Szukanie(tab, 0, tab.length, liczba);
    }
}
