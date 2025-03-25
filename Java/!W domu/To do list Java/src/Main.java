import javax.swing.*;
import java.io.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
        String fileName = "toDoList.txt";
        String line = "";

        Scanner scanner = new Scanner(new FileReader(fileName));

        while (scanner.hasNextLine()) {
            line += scanner.nextLine()+"\n";
        }

        JOptionPane.showMessageDialog(null, line);

        FileWriter fileWriter = new FileWriter(fileName, true);
        PrintWriter outputfile = new PrintWriter(fileWriter);

        outputfile.println(JOptionPane.showInputDialog("Podaj zadanie do wykonania"));

        outputfile.close();
    }
}