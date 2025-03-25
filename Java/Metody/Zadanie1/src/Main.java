import java.text.MessageFormat;
import java.util.Scanner;

public class Main {
    /// Metoda do wczytywania danych
    static Scanner scanner = new Scanner(System.in);

    /**
     * Metoda która wyswietla komunikat "Podaj liczbe szklanek",
     * nastepnie prosi o wprowadzenie liczby całkowitej od uzytkownika,
     * zwracaca liczbe szklanek
     * @return zwraca liczbe szklanek
     * */
    public static int getCups(){
        System.out.print("Podaj liczbe szklanek -> ");
        return scanner.nextInt();
    }

    /**
     * Metoda obliczajaca ilosc litrow w szklanakch
     * @param szklanki liczba szklanek
     * @return zwraca liczbe litrow w wszystkich szklankach
     * */
    public static double cupsToOunces(int szklanki) {
        return szklanki * 0.3;
    }
    /// Wypisuje liczbe szklanek oraz liczbe litrow mlaka
    public static void displayResult() {
        int szklanki = getCups();
        System.out.println(MessageFormat.format("W {0} szklankach jest {1} Litrow mleka", szklanki,cupsToOunces(szklanki)));
    }

    public static void main(String[] args) {
    displayResult();
    }
}