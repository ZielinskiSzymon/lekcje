import javax.swing.*;

public class Main {
    public static void main(String[] args){
        int n, m=0, temp, counter = 1;

        n = Integer.parseInt(JOptionPane.showInputDialog("Podaj liczbe"));

        temp = n;

        while(temp>0){
            if (temp%2!=0){
                m+=(temp%10)*counter;
                counter*=10;
            }
            temp/=10;
        }

        if (m>0)
            System.out.println("nieparzystym skrótem liczby "+ n + " jest liczba "+ m);
        else
            System.out.println("Nieparzysty skrot liczby "+ n +" nie istnieje");
    }
}