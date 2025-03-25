import javax.swing.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        double salary;
        int creditRating;
        String input;

        input = JOptionPane.showInputDialog("Jakie jest twoje roczne wynagrodzenie?");
        salary = Double.parseDouble(input);

        input= JOptionPane.showInputDialog("Jaka jest twoja ocena kredytowa\n" +
                "Wpisz cyfre od 1 do 10" +
                " (10 = bardzo wysoka, 1 bardzo niska)");
        creditRating = Integer.parseInt(input);

        if (salary >= 20000 && creditRating >= 7)
            qualify();
        else
            noQualify();

        System.exit(0);
    }
    public static void qualify(){
        JOptionPane.showMessageDialog(null,"Gratulacje, kwalifikujesz sie do " +
                "kredytu");
    }
    public static  void noQualify (){
        JOptionPane.showMessageDialog(null,"Przykto mi, nie kwalifikujesz sie" +
                " do kredytu");
    }
}