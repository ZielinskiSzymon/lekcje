import java.util.Scanner;

public class Main {
    public static void Sprawdz(int liczba) {
        Scanner scanner = Scanner(System.in);

        System.out.print("Podaj wielksoc tablicy");
        int n = scanner.nextInt();
        int[] tab;
        tab = new int[n];
        for (int i = 0; i < n; i++) {
            tab[i] = i+1;
        }
        int licznik=0;

        while (licznik < liczba) {
            System.out.print("Podaj wielksoc tablicy");
            int w = scanner.nextInt();

        }
    }
}