public class Main {
    static int[] naBinarne(int liczba) {
        int[] tablica = new int[20];
        int i = 0;

        while (liczba > 0) {
            tablica[i] = liczba % 2;
            liczba /= 2;
            i++;
        }

        int[] wynik = new int[i];
        for (int j = 0; j < i; j++) {
            wynik[j] = tablica[i - j - 1];
        }
        return wynik;
    }

    static void szukanieJedynek(int[] tab) {
        for (int i = tab.length-1; i >= 0; i--) {
            if (tab[i] == 1) {
                System.out.print((i-tab.length)* -1 + ",");
            }
        }
        System.out.println();
    }


    public static void main(String[] args) {
        int[] tab = naBinarne(75);

        for (int arg : tab){
            System.out.print(arg);
        }
        System.out.println();

        szukanieJedynek(tab);
    }
}
