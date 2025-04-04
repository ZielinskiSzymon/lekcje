import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    private static Map<Character, String> textToMorse = new HashMap<>();

    static {
        // Inicjalizacja mapy tekst -> Morse
        textToMorse.put('A', ".-");
        textToMorse.put('B', "-...");
        textToMorse.put('C', "-.-.");
        textToMorse.put('D', "-..");
        textToMorse.put('E', ".");
        textToMorse.put('F', "..-.");
        textToMorse.put('G', "--.");
        textToMorse.put('H', "....");
        textToMorse.put('I', "..");
        textToMorse.put('J', ".---");
        textToMorse.put('K', "-.-");
        textToMorse.put('L', ".-..");
        textToMorse.put('M', "--");
        textToMorse.put('N', "-.");
        textToMorse.put('O', "---");
        textToMorse.put('P', ".--.");
        textToMorse.put('Q', "--.-");
        textToMorse.put('R', ".-.");
        textToMorse.put('S', "...");
        textToMorse.put('T', "-");
        textToMorse.put('U', "..-");
        textToMorse.put('V', "...-");
        textToMorse.put('W', ".--");
        textToMorse.put('X', "-..-");
        textToMorse.put('Y', "-.--");
        textToMorse.put('Z', "--..");

        textToMorse.put('0', "-----");
        textToMorse.put('1', ".----");
        textToMorse.put('2', "..---");
        textToMorse.put('3', "...--");
        textToMorse.put('4', "....-");
        textToMorse.put('5', ".....");
        textToMorse.put('6', "-....");
        textToMorse.put('7', "--...");
        textToMorse.put('8', "---..");
        textToMorse.put('9', "----.");

        textToMorse.put('.', ".-.-.-");
        textToMorse.put(',', "--..--");
        textToMorse.put('?', "..--..");
        textToMorse.put(' ', "/");
    }

    public static void wykonaj() {
        System.out.println("=====ZADANIE 1=====");

        Scanner scanner = new Scanner(System.in);
        System.out.print("Podaj dowolny ciag znaków: ");
        String input = scanner.nextLine();

        String output = "";

        for (char c : input.toUpperCase().toCharArray()) {
            String morseChar = textToMorse.get(c);
            if (morseChar != null) {
                output += morseChar + " ";
            }
        }

        System.out.println("Kod Morse: " + output.trim());
    }

    public static void main(String[] args) {
        wykonaj();
    }
}