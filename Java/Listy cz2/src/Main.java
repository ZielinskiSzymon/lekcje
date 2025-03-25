import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scannner = new Scanner(System.in);
        boolean shuldContinue = true;

        Party party = new Party();

        while (shuldContinue){
            System.out.println("Wybierz opcje");
            System.out.println("1. wyswietl uzytkownikow");
            System.out.println("2. dodaj goscia");
            System.out.println("3. Wyswietl potrawy");
            System.out.println("4. Znajdz po numerze telefonu");
            System.out.println("5. wysjcie");

            int userChoise = scannner.nextInt();

            switch (userChoise){
                case 1 -> party.displayGuests();
                case 2 -> party.addGuest();
                case 3 -> party.displayMeals();
                case 4 -> party.finfGuestByphoneNumber();
                case 5 -> shuldContinue = false;
                default -> System.out.println("nie ma takiej opcji");
            }
        }
    }
}