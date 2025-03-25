import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {

        File file = new File("slowa.txt");
        Scanner scanner = new Scanner(file);

        FileWriter writer = new FileWriter("wyniki4_1.txt");

        while(scanner.hasNextLine()) {
            String line = scanner.nextLine();

            int countW = 0;
            int countK = 0;
            for (int j = 0; j < line.length(); j++) {
                char ch = line.charAt(j);
                if (ch == 'w') {
                    countW++;
                } else if (ch == 'k') {
                    countK++;
                }
            }

            if (countW == countK) {
                writer.write(line + "\n");
            }
        }

        scanner.close();
        writer.close();
    }
}
