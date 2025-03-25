import javax.swing.*;

// Tip to <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        // Okna dialogowe - korztstamy z klasy JOptionPane

//        String firstName, lastname;
//
//        firstName = JOptionPane.showInputDialog("Jak masz na imie");
//        lastname = JOptionPane.showInputDialog("Jak masz na nazwisko");
//
//        JOptionPane.showMessageDialog(null, "Witaj, "+firstName+" "+lastname);
//        System.exit(0);

        // Konwersja na liczby


        //przyklad 2

//        String inputStrig, name;
//        int hours;
//        double payRate, grossPay;
//
//        name=JOptionPane.showInputDialog("Enter yoour name");
//        inputStrig = JOptionPane.showInputDialog("Ile godzin pracowałes?");
//        hours = Integer.parseInt(inputStrig);
//
//        inputStrig = JOptionPane.showInputDialog("Stawka godzinna?");
//        payRate = Integer.parseInt(inputStrig);
//
//        grossPay = hours *payRate;
//        JOptionPane.showMessageDialog(null,"Welcome "+name+" "+hours+" "+" "+grossPay+"zł");

        // PRzyklad 3

//        String name1="Alan",
//                name2="Alan",
//                name3 ="Alak";
//        if (name1.equals(name2)){
//            System.out.println(name1+" i "+name2 +" sa identyczne");
//        }else {
//            System.out.println("nie sa dentyczne");
//        }
//
//        // porwnywanie znak po znaku funkcja compareTo
//
//        if (name1.compareTo(name2)<0){
//            System.out.println(name1+" > "+name2);
//        }

        //formatowanie

        double  a = 4.0,
                b = 7.0,
                c = 2.0;
        System.out.printf("%f %f %f",a,b,c);

        // Ogolna zasada specyfikatorow formatowania

        // %[opcje][szerokosc][precyzja][konwersja]

        double temp = 34.42819;
        System.out.printf("\nTemperaura wynosi %.2f stopnia.\n: ",temp);

        double v1 = 123.45678,
                v2 = 123.45678,
                v3 = 123.45678;

        System.out.printf("%.1f %.2f %.3f",v1,v2,v3);






    }
}