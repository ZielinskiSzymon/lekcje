import java.util.Random;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Random rand = new Random();
        String acces = String.valueOf('t');
        int die1,die2;

        while (acces.equalsIgnoreCase("t")) {
            die1 = rand.nextInt(6)+1;
            die2 = rand.nextInt(6)+1;

            System.out.println("Wyrzuciles "+ die1 + " i "+ die2);
            System.out.println("Jeszcze raz? (t/n)");
            acces = sc.next();
        }

    }
}