import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double temperature = 102.5,
                guess = 0;

        boolean acces = true;
        do {
            System.out.print("Podaj temperature -> ");
            guess = scanner.nextDouble();

            if (temperature == guess){
                System.out.println("Brawo zgadłes!!!");
                acces = false;
            }else if (temperature > guess)
                System.out.println("Temperatura jest wyższa.");
            else if (temperature < guess)
                System.out.println("temperatura jest niższa.");
        }while (acces);
    }
}