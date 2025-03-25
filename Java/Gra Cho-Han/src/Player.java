import java.util.Scanner;

public class Player {
    private String name;
    private String guess;
    private int points;

    public Player(String playerName) {
        this.name = playerName;
        this.points = 0;
    }

    public void makeGuess(Scanner scanner) {
        String[] validGuesses = {"Cho", "Han"};

        boolean validInput = false;
        while (!validInput) {
            String userGuess = scanner.nextLine();

            for (String valid : validGuesses) {
                if (userGuess.equalsIgnoreCase(valid)) {
                    this.guess = userGuess;
                    validInput = true;
                    break;
                }
            }

            if (!validInput) {
                System.out.println("Niepoprawna odpowiedź! Spróbuj ponownie.");
            }
        }
    }

    public void addPoints(int newPoints) {
        this.points += newPoints;
    }

    public String getName() {
        return name;
    }

    public String getGuess() {
        return guess;
    }

    public int getPoints() {
        return points;
    }
}
