import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Player player1 = new Player("Gracz 1");
        Player player2 = new Player("Gracz 2");
        Dealer dealer = new Dealer();

        for (int round = 1; round <= 5; round++) {
            System.out.println("Runda " + round);

            System.out.println("Gracz 1, Twój zakład (Cho/Han): ");
            player1.makeGuess(scanner);
            System.out.println("Gracz 1 obstawił: " + player1.getGuess());

            System.out.println("Gracz 2, Twój zakład (Cho/Han): ");
            player2.makeGuess(scanner);
            System.out.println("Gracz 2 obstawił: " + player2.getGuess());

            dealer.rollDice();
            System.out.println("Wyniki rzutu: " + dealer.getDie1Value() + " + " + dealer.getDie2Value());
            System.out.println("Krupier ogłasza: " + dealer.getChoOrHan());

            if (player1.getGuess().equals(dealer.getChoOrHan())) {
                player1.addPoints(1);
                System.out.println(player1.getName() + " zgadł poprawnie!");
            } else {
                System.out.println(player1.getName() + " nie zgadł.");
            }

            if (player2.getGuess().equals(dealer.getChoOrHan())) {
                player2.addPoints(1);
                System.out.println(player2.getName() + " zgadł poprawnie!");
            } else {
                System.out.println(player2.getName() + " nie zgadł.");
            }

            System.out.println();
        }

        System.out.println("Koniec gry!");
        System.out.println(player1.getName() + " zdobył " + player1.getPoints() + " punktów.");
        System.out.println(player2.getName() + " zdobył " + player2.getPoints() + " punktów.");

        if (player1.getPoints() > player2.getPoints()) {
            System.out.println(player1.getName() + " jest zwycięzcą!");
        } else if (player2.getPoints() > player1.getPoints()) {
            System.out.println(player2.getName() + " jest zwycięzcą!");
        } else {
            System.out.println("Remis!");
        }

        scanner.close();
    }
}
