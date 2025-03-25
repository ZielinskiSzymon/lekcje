import java.io.FileNotFoundException;
import java.io. FileWriter;
import java.io.PrintWriter;
import java.util.Scanner;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        // Zapis i oczyt z pliku

        // Scanner i opcjonalnie FileReader
        // BufforedWriter i opcjonalnie FileWriter
        // BufforedReader i opcjonalnie FileReader

        /*
         * Ten program zapisuje dane w pliku tekstowym
         */

        String fileName,
                friendName;
        int numFriends;

        Scanner input = new Scanner(System.in);

        System.out.print("Ilu masz przyjaciół? ");
        numFriends = input.nextInt();

        System.out.print("Podaj nazwe pliku? ");
        fileName = input.next() + ".txt";

        // Otwieramy plik do zapisu


        PrintWriter outfile = new PrintWriter(fileName);

        for (int i = 0; i < numFriends; i++) {
            System.out.print("Podaj imie przyjaciela numer "+ (i+1) +" -> ");
            friendName = input.next();
            outfile.println(friendName);
        }

        outfile.close();

//aby dolaczyc dane do instniejacego pliku tworzymy instancje klasy FileWriter
        FileWriter fileWriter = new FileWriter("jan.txt", true);
        PrintWriter outputfile2 = new PrintWriter(fileWriter);
        outputfile2.println("Dopisuje do pliku imie");
        outputfile2.println("Dopisuje do pliku drugie imie");
        outputfile2.close();
    }
}