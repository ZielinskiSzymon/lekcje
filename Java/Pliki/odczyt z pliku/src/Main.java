import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(System.in);
        System.out.print("Podaj nazwe pliku -> ");
        String fileName = sc.nextLine()+".txt";

        // Otwiera plik
        File f = new File(fileName);
        Scanner inputFile = new Scanner(f);
        // wczytuje pierwszy wiersz
        String line = inputFile.nextLine();
        // wypisuje wczytany wiersz
        System.out.println("Pierwszy wiersz to: " + line);
        // zamykanie
        inputFile.close();

    }
}