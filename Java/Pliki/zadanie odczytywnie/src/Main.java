import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner sc = new Scanner(System.in);
        String fileName = "zadanie.txt";
        double line = 0;

        File f = new File(fileName);
        Scanner outputFile = new Scanner(f);
        for (int i = 0; i < 5; i++) {
            line += Double.parseDouble(outputFile.nextLine());
        }

        System.out.println("Suma liczb w pliku -> " + line);

        outputFile.close();
    }
}