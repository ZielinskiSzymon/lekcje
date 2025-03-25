import javax.swing.*;

public class Main {
    public static void main(String[] args){
        JFrame frame = new JFrame("Powitanie");
        String htmlText = "<html><FONT SIZE=+3>"+
                          "Witaj<font color=red><b> Javo!</b></font><br>"+
                          "<font color=blue>.... A wiaj!</font></html>";
        Icon icon = new ImageIcon("java_logo.png");
        JLabel label = new JLabel(htmlText, icon, JLabel.CENTER);
        frame.add(label);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }
}