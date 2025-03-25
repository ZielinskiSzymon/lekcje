import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String znaki;
        char znak;
        int ile = 0;
        System.out.print("Podaj lancuch znaków -> ");
        znaki = sc.nextLine();

        System.out.print("Jaki znak policzyc -> ");
        znak = sc.nextLine().charAt(0);

        for (int i = 0; i < znaki.length(); i++) {
            if (znaki.charAt(i) == znak) {
                ile++;
            }
        }

        System.out.println("Znak "+znak + " wystepuje w lancuchu znakow " + ile + " razy.");
    }
}